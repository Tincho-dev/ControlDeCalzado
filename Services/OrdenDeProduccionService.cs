using Common;
using Model.Custom;
using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Services
{
    public class OrdenDeProduccionService
    {
        #region CRUD
        public static IEnumerable<OrdenDeProduccionGrid> GetAll()
        {
            var result = new List<OrdenDeProduccionGrid>();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from op in db.OrdenesDeProduccion
                          from col in db.Colores.Where(x => x.CodigoColor == op.CodigoColor).DefaultIfEmpty()
                          from mo in db.Modelos.Where(x => x.Sku == op.Sku).DefaultIfEmpty()
                          from li in db.LineasDeProduccion.Where(x => x.IdLinea == op.IdLinea).DefaultIfEmpty()
                          from us in db.ApplicationUsers.Where(x => x.Id == op.UserId).DefaultIfEmpty()
                          select new OrdenDeProduccionGrid
                          {
                              Numero = op.Numero,
                              Estado = op.Estado,
                              FechaDeInicio = op.FechaDeInicio,
                              FechaDeFin = op.FechaDeFin,
                              CantidadDePrimera = op.CantidadDePrimera,
                              Color = col.DescripcionColor,
                              Sku = op.Sku,
                              Modelo = mo.Denominacion,
                              Linea = li.NumeroLinea,
                              UserId = op.UserId,
                              Supervisor = us.Name + " " + us.LastName
                          }).OrderBy(x => x.FechaDeInicio).ToList();
                          
            }
            return result;
        }

        public static OrdenDeProduccionGrid GetDetails(string id)
        {
            var result = new OrdenDeProduccionGrid();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from op in db.OrdenesDeProduccion.Where(x => x.Numero == id)
                          from col in db.Colores.Where(x => x.CodigoColor == op.CodigoColor).DefaultIfEmpty()
                          from mo in db.Modelos.Where(x => x.Sku == op.Sku).DefaultIfEmpty()
                          from li in db.LineasDeProduccion.Where(x => x.IdLinea == op.IdLinea).DefaultIfEmpty()
                          from us in db.ApplicationUsers.Where(x => x.Id == op.UserId).DefaultIfEmpty()
                          select new OrdenDeProduccionGrid
                          {
                              Numero = op.Numero,
                              Estado = op.Estado,
                              FechaDeInicio = op.FechaDeInicio,
                              FechaDeFin = op.FechaDeFin,
                              CantidadDePrimera = op.CantidadDePrimera,
                              Color = col.DescripcionColor,
                              Sku = op.Sku,
                              Modelo = mo.Denominacion,
                              Linea = li.NumeroLinea,
                              UserId = op.UserId,
                              Supervisor = us.Name + " " + us.LastName
                          }).Single();

            };

            return result;
        }
        public static OrdenDeProduccion Get(string id)
        {
            var result = new OrdenDeProduccion();

            using (var db = new ApplicationDbContext())
            {
                result = db.OrdenesDeProduccion.Where(x => x.Numero == id).Single();
            }
            return result;
        }
        public static void Create(OrdenDeProduccion model)
        {
            //organizar codigo y condicionales

            //validar turno a la hora de crear
            bool estaEnTurno = TurnoService.EstaEnTurno();
            var lineaOcupada = LineaOcupada(model.IdLinea);
            if (!estaEnTurno)
            {
                //o no devolver nada y validar en el controller
                throw new ApplicationException("No existe turno");
            }
            using (var db = new ApplicationDbContext())
            {
                var OrdenDeProduccion = new OrdenDeProduccion();
                var NumeroOp = db.OrdenesDeProduccion.Where(x => x.Numero == model.Numero).FirstOrDefault();
                    if (NumeroOp == null)
                    {
                        OrdenDeProduccion.Numero = model.Numero;
                    }
                    else
                    {
                        throw new ApplicationException("Ya existe una OP con este Numero");
                    }
                if (lineaOcupada == null)
                {
                    OrdenDeProduccion.IdLinea = model.IdLinea;
                }
                else
                {
                    throw new ApplicationException("Esta linea ya esta ocupada en una OP activa");
                }

                OrdenDeProduccion.Sku = model.Sku;
                OrdenDeProduccion.CodigoColor = model.CodigoColor;
                //validar op
                OrdenDeProduccion.FechaDeInicio = model.FechaDeInicio;
                OrdenDeProduccion.Estado = EstadoOp.Pausada;
                //OrdenDeProduccion.Jornadas = model.Jornadas;

                db.OrdenesDeProduccion.Add(OrdenDeProduccion);
                db.SaveChanges();
            }

        }
        public static void Update(OrdenDeProduccion model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.OrdenesDeProduccion.Where(x => x.Numero == model.Numero).Single();

                originalEntity.Numero = model.Numero;
                originalEntity.Sku = model.Sku;
                originalEntity.CodigoColor = model.CodigoColor;
                originalEntity.IdLinea = model.IdLinea;
                originalEntity.FechaDeFin = model.FechaDeFin;
                originalEntity.Jornadas = model.Jornadas;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(string id)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    OrdenDeProduccion OrdenDeProduccion = db.OrdenesDeProduccion.Where(x => x.Numero == id).Single();

                    db.OrdenesDeProduccion.Remove(OrdenDeProduccion);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("No se puede eliminar la Orden de Produccion" + id);
            }
        }
        #endregion

        #region Jornada y Horario de Control

        public static bool JornadaActiva(string numero)
        {
            var idTurno = TurnoService.GetId();
            var FinJornada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) + TurnoService.Get(idTurno).HoraDeFin;
            using (var db = new ApplicationDbContext())
            {
                return db.JornadasLaborales
                    .Where(j => j.FechaFinJornada == FinJornada && j.Numero == numero)
                    .Any();
            }
        }
        public static void AgregarJornada(string Numero)
        {
            var op = Get(Numero);
            var idTurno = TurnoService.GetId();
            var FinJornada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) + TurnoService.Get(idTurno).HoraDeFin;
            using (var db = new ApplicationDbContext())
            {
                var jornada = new JornadaLaboral
                {
                    Numero = Numero,
                    FechaInicioJornada = DateTime.Now,
                    IdTurno = idTurno,
                    FechaFinJornada = FinJornada
                };
                op.Jornadas.Add(jornada);
                db.JornadasLaborales.Add(jornada);
                db.SaveChanges();
            }
        }
        public static void AgregarHorarioDeControl(string Numero)
        {
            var op = Get(Numero);
            var idTurno = TurnoService.GetId();
            var FinJornada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) + TurnoService.Get(idTurno).HoraDeFin;

            using (var db = new ApplicationDbContext())
            {
                var horarioDeControl = new HorarioDeControl
                {
                    HoraInicio = DateTime.Now,
                    HoraFin = FinJornada,
                    IdJornada = db.JornadasLaborales
                    .Where(j => j.FechaFinJornada == FinJornada && j.Numero == Numero)
                    .OrderByDescending(j => j.FechaInicioJornada).First().IdJornada,
                };
                db.HorariosDeControl.Add(horarioDeControl);
                db.SaveChanges();
            }
        }

        public static int HorarioActual(string numeroOp)
        {
            using (var db = new ApplicationDbContext())
            {
                return (from j in db.JornadasLaborales.Where(j => j.Numero == numeroOp).OrderByDescending(j => j.FechaInicioJornada)
                        from hdc in db.HorariosDeControl.Where(hd => hd.IdJornada == j.IdJornada).OrderBy(h => h.HoraInicio)
                        select hdc).OrderByDescending(h => h.HoraInicio).FirstOrDefault().IdHorarioDeControl;
            }
        }

        public static HorarioDeControl ObtenerHorarioDeControl(string NumeroDeOrden)
        {
            HorarioDeControl horarioDeControl = null;
            using (var db = new ApplicationDbContext())
            {
                horarioDeControl = (
                                    from j in db.JornadasLaborales.Where(j => j.Numero == NumeroDeOrden)
                                    from hdc in db.HorariosDeControl.Where(h => h.IdJornada == j.IdJornada)
                                    select hdc
                                    ).OrderByDescending(h => h.HoraInicio).First();
            }
            return horarioDeControl;
        }

        public static void GetJornadaActual(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);

            using (var db = new ApplicationDbContext())
            {
                Modelo modelo = db.Modelos.Find(op.Sku);
                JornadaLaboral jornada = db.JornadasLaborales
                    .Where(j => j.Numero == id)
                    .OrderByDescending(j => j.FechaFinJornada)
                    .FirstOrDefault();
            }
        }

        #endregion

        #region Consultas
        public static void RegistrarIncidencia(int cantidad, int idHorarioDeControl)
        {
            Incidencia incidencia = new Incidencia()
            {
                FechaIncidencia = DateTime.Now,
                CantidadIncidencia = cantidad,
                Tipo = TipoIncidencia.Primera,
                IdHorarioDeControl = idHorarioDeControl

            };

            using (var db = new ApplicationDbContext())
            {
                db.Incidencias.Add(incidencia);
                db.SaveChanges();
            }
        }

        public static void RegistrarIncidencia(int cantidad, int idDefecto, Pie pie, int idHorarioDeControl)
        {
            Incidencia incidencia = new Incidencia()
            {
                FechaIncidencia = DateTime.Now,
                CantidadIncidencia = cantidad,
                IdDefecto = idDefecto,
                Pie = pie,
                Tipo = TipoIncidencia.Defecto,
                IdHorarioDeControl = idHorarioDeControl
            };

            using (var db = new ApplicationDbContext())
            {
                db.Incidencias.Add(incidencia);
                db.SaveChanges();
            }
        }

        public static int TotalIncidenciasPrimera(string numero)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                result = (
                            from op in db.OrdenesDeProduccion.Where(o => o.Numero == numero)
                            from j in db.JornadasLaborales.Where(j => j.Numero == op.Numero)
                            from hdc in db.HorariosDeControl.Where(h => h.IdJornada == j.IdJornada)
                            from i in db.Incidencias.Where(i => i.IdHorarioDeControl == hdc.IdHorarioDeControl && i.Tipo == TipoIncidencia.Primera)
                            select i.CantidadIncidencia).Sum();
            }
            return result;
        }

        public static int TotalIncidenciasPrimeraEnHorarioDeControl(int idHorarioDeControl)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                var horario = db.HorariosDeControl.Where(h => h.IdHorarioDeControl == idHorarioDeControl).Include(h => h.Incidencias).Single();
                result = horario.Incidencias.Where(i => i.Tipo == TipoIncidencia.Primera).Sum(i => i.CantidadIncidencia);
            }
            return result;
        }

        public static int TotalIncidenciasDefectoPorPie(int idHorarioDeControl, Pie pie, TipoDefecto tipoDefecto, int idDefecto)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                result = (
                          from d in db.Defectos.Where(d => d.TipoDefecto == tipoDefecto)
                          from i in db.Incidencias
                          .Where(i => i.IdHorarioDeControl == idHorarioDeControl &&
                          i.Pie == pie &&
                          i.IdDefecto == d.IdDefecto &&
                          i.IdDefecto == idDefecto)
                          select i
                          ).Sum(i => i.CantidadIncidencia);
            }
            return result;
        }

        public static void CargarAlertas(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);

            using (var db = new ApplicationDbContext())
            {
                Modelo modelo = db.Modelos.Find(op.Sku);
                JornadaLaboral jornada = db.JornadasLaborales
                    .Where(j => j.Numero == id)
                    .OrderByDescending(j => j.FechaFinJornada)
                    .FirstOrDefault();
                db.Alertas.Add(new Alerta
                {
                    TipoDefecto = TipoDefecto.Observado,
                    IdJornada = jornada.IdJornada,
                    LimiteInferior = modelo.LimiteInferiorDeObservado,
                    LimiteSuperior = modelo.LimiteSuperiorDeObservado
                });
                db.Alertas.Add(new Alerta
                {
                    TipoDefecto = Common.TipoDefecto.Reproceso,
                    IdJornada = jornada.IdJornada,
                    LimiteInferior = modelo.LimiteInferiorDeReproceso,
                    LimiteSuperior = modelo.LimiteSuperiorDeReproceso
                });
                jornada.Alertas.AddRange(db.Alertas.Where(a => a.IdJornada == jornada.IdJornada).ToArray());
                db.SaveChanges();
            }
        }

        public static OrdenDeProduccion LineaOcupada(int linea)
        {
            var result = new OrdenDeProduccion();

            using (var ctx = new ApplicationDbContext())
            {
                result = ctx.OrdenesDeProduccion.Where(x => x.IdLinea == linea && (x.Estado == Common.EstadoOp.Iniciada || x.Estado == Common.EstadoOp.Pausada)).DefaultIfEmpty().Single();
            }

            return result;
        }
        #endregion

        #region Asignar y Desvincular Op
        public static OrdenDeProduccion GetOP(string user)
        {
            var result = new OrdenDeProduccion();

            using (var ctx = new ApplicationDbContext())
            {
                result = ctx.OrdenesDeProduccion.Where(x => x.UserId == user && x.Estado != EstadoOp.Finalizada).FirstOrDefault();
            }
            return result;
        }

        public static IEnumerable<OrdenDeProduccion> GetOPSupervisor(string user)
        {
            var result = new List<OrdenDeProduccion>();

            using (var ctx = new ApplicationDbContext())
            {
                result = ctx.OrdenesDeProduccion.Where(x => x.UserId == user || x.Estado != EstadoOp.Finalizada).OrderBy(x => x.FechaDeInicio).ToList();
            }
            return result;
        }

        public static void AsignarSupervisorCalidad(string numero, string userid)
        {
            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var Op = ctx.OrdenesDeProduccion.Where(x => x.Numero == numero).Single();

                    Op.UserId = userid;

                    ctx.Entry(Op).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void AsociarmeAOp(string numero)
        {
            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var Op = ctx.OrdenesDeProduccion.Where(x => x.Numero == numero).Single();

                    Op.UserId = Common.CurrentUser.Get.UserId;

                    ctx.Entry(Op).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DesvincularSupervisorDeCalidad(string numero)
        {
            try
            {
                using(var db = new ApplicationDbContext())
                {
                    var Op = db.OrdenesDeProduccion.Where(x => x.Numero == numero).Single();

                    if(Op.UserId != null)
                    {
                        Op.UserId = null;
                    } else
                    {
                        throw new Exception();
                    }

                    db.Entry(Op).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        #endregion

        #region Updates

        public static void UpdateCantidadDeParesDePrimera(string Numero, int cantidad)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.OrdenesDeProduccion.Where(x => x.Numero == Numero).Single();

                originalEntity.CantidadDePrimera = cantidad;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void IniciarOp(string Numero)
        {
            using (var db = new ApplicationDbContext())
            {
                var original = db.OrdenesDeProduccion.Where(x => x.Numero == Numero).Single();

                original.Estado = EstadoOp.Iniciada;

                db.Entry(original).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void CambiarEstadoOrdenDeProduccion(string Numero, EstadoOp estadoOp)
        {
            using (var db = new ApplicationDbContext())
            {
                var original = db.OrdenesDeProduccion.Where(x => x.Numero == Numero).Single();

                if (estadoOp == EstadoOp.Finalizada)
                {
                    original.Estado = EstadoOp.Finalizada;
                }

                original.Estado = estadoOp;

                db.Entry(original).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void TerminarOp(string Numero)
        {
            using (var db = new ApplicationDbContext())
            {
                var original = db.OrdenesDeProduccion.Where(x => x.Numero == Numero).Single();

                original.Estado = EstadoOp.Finalizada;
                original.FechaDeFin = DateTime.Now;

                db.Entry(original).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void PausarOp(string Numero)
        {
            using (var db = new ApplicationDbContext())
            {
                var original = db.OrdenesDeProduccion.Where(x => x.Numero == Numero).Single();

                original.Estado = EstadoOp.Pausada;

                db.Entry(original).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        #endregion
    }
}

