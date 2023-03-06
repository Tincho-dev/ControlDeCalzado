using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TurnoService
    {
		public static IEnumerable<Turno> GetAll()
		{
			var result = new List<Turno>();

			using (var db = new ApplicationDbContext())
			{
				result = (
						  from col in db.Turnos
						  select col
						  ).ToList();
			}
			return result;
		}

		public static Turno Get(int id)
		{
			var result = new Turno();

			using (var db = new ApplicationDbContext())
			{
				result = (from col in db.Turnos.Where(x => x.IdTurno == id)
						  select col
						  ).Single();
			}
			return result;
		}

		public static int GetId()
        {
			var id = 0;
			Console.WriteLine(DateTime.Now.TimeOfDay);
			TimeSpan now = DateTime.Now.TimeOfDay;
			using (var db = new ApplicationDbContext())
            {
				Console.WriteLine(db.Turnos.First().HoraDeFin);
				Console.WriteLine(now);
				Console.WriteLine("Buscando...");
				Console.WriteLine(db.Turnos.First().HoraDeInicio);
				id = db.Turnos.First().IdTurno;
                //id = db.Turnos.Where(t => t.HoraDeInicio > now && t.HoraDeFin < now).Single().IdTurno;
            }
			return id;
        }

		public static void Create(Turno turn)
		{
			var comparacionHora = TimeSpan.Compare(turn.HoraDeFin, turn.HoraDeInicio);
			if (comparacionHora == -1 || comparacionHora == 0)
			{
				// Generar excepcion
				// -1 -> Se ingreso hora de fin antes de hora de inicio
				// 0 -> Se ingreso misma hora de inicio y de fin
				throw new NotImplementedException();
			}
			else
			{
				// Comparamos si hay superposición de horas
				List<Turno> listadoTurnos = GetAll().ToList();
				foreach (Turno trn in listadoTurnos)
				{
					if (TimeSpan.Compare(turn.HoraDeInicio, trn.HoraDeInicio) == 0)
					{
						//Generar excepcion
						throw new NotImplementedException();
					}
				}
			}
			using (var db = new ApplicationDbContext())
			{
				var turno = new Turno();
				turno.HoraDeInicio = turn.HoraDeInicio;
				turno.HoraDeFin = turn.HoraDeFin;
				db.Turnos.Add(turno);
				db.SaveChanges();
			}
		}

		public static void Update(Turno turn)
		{
			using (var db = new ApplicationDbContext())
			{
				var originalEntity = db.Turnos.Where(x => x.IdTurno == turn.IdTurno).Single();

				originalEntity = turn;

				db.Entry(originalEntity).State = EntityState.Modified;
				db.SaveChanges();
			}
		}

		public static void Delete(int id)
		{
			try
			{
				using (var db = new ApplicationDbContext())
				{
					Turno turno = db.Turnos.Where(x => x.IdTurno == id).Single();

					db.Turnos.Remove(turno);
					db.SaveChanges();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public static bool EstaEnTurno()
		{
			TimeSpan horaActual = DateTime.Now.TimeOfDay;
			
			bool bandera = false;
			List<Turno> listadoTurnos = GetAll().ToList();
			foreach (Turno turno in listadoTurnos)
			{
				//var comparacionHora = TimeSpan.Compare(horaActual, trn.HoraDeInicio);
				//var comparacionHora2 = TimeSpan.Compare(trn.HoraDeFin, horaActual);
				
				//if ((horaActual < trn.HoraDeInicio) && (horaActual > trn.HoraDeFin))
				if (TimeSpan.Compare(horaActual, turno.HoraDeInicio) == 1 &&
					TimeSpan.Compare(turno.HoraDeFin, horaActual) == 1)
				{
					// El horario actual se encuentra dentro del horario de un turno.
					bandera = true;
					break;
				}
			}

			return bandera;
		}
	}
}
