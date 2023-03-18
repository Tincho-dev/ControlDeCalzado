namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alertas",
                c => new
                    {
                        IdAlerta = c.Int(nullable: false, identity: true),
                        FechaLimite = c.DateTime(),
                        FechaReinicio = c.DateTime(),
                        TipoDefecto = c.Int(nullable: false),
                        IdJornada = c.Int(nullable: false),
                        LimiteInferior = c.Int(nullable: false),
                        LimiteSuperior = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAlerta)
                .ForeignKey("dbo.JornadaLaborals", t => t.IdJornada, cascadeDelete: true)
                .Index(t => t.IdJornada);
            
            CreateTable(
                "dbo.JornadaLaborals",
                c => new
                    {
                        IdJornada = c.Int(nullable: false, identity: true),
                        FechaInicioJornada = c.DateTime(nullable: false),
                        FechaFinJornada = c.DateTime(nullable: false),
                        IdTurno = c.Int(nullable: false),
                        Numero = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IdJornada)
                .ForeignKey("dbo.OrdenDeProduccions", t => t.Numero)
                .ForeignKey("dbo.Turnoes", t => t.IdTurno, cascadeDelete: true)
                .Index(t => t.IdTurno)
                .Index(t => t.Numero);
            
            CreateTable(
                "dbo.HorarioDeControls",
                c => new
                    {
                        IdHorarioDeControl = c.Int(nullable: false, identity: true),
                        HoraInicio = c.DateTime(nullable: false),
                        HoraFin = c.DateTime(nullable: false),
                        IdJornada = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdHorarioDeControl)
                .ForeignKey("dbo.JornadaLaborals", t => t.IdJornada, cascadeDelete: true)
                .Index(t => t.IdJornada);
            
            CreateTable(
                "dbo.Incidencias",
                c => new
                    {
                        IdIncidencia = c.Int(nullable: false, identity: true),
                        FechaIncidencia = c.DateTime(nullable: false),
                        CantidadIncidencia = c.Int(nullable: false),
                        IdDefecto = c.Int(),
                        Pie = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        IdHorarioDeControl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdIncidencia)
                .ForeignKey("dbo.Defectoes", t => t.IdDefecto)
                .ForeignKey("dbo.HorarioDeControls", t => t.IdHorarioDeControl, cascadeDelete: true)
                .Index(t => t.IdDefecto)
                .Index(t => t.IdHorarioDeControl);
            
            CreateTable(
                "dbo.Defectoes",
                c => new
                    {
                        IdDefecto = c.Int(nullable: false, identity: true),
                        DescripcionDefecto = c.String(),
                        TipoDefecto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDefecto);
            
            CreateTable(
                "dbo.OrdenDeProduccions",
                c => new
                    {
                        Numero = c.String(nullable: false, maxLength: 128),
                        Estado = c.Int(nullable: false),
                        FechaDeInicio = c.DateTime(nullable: false),
                        FechaDeFin = c.DateTime(),
                        CantidadDePrimera = c.Int(nullable: false),
                        CantidadPorHermanado = c.Int(nullable: false),
                        CodigoColor = c.String(maxLength: 128),
                        Sku = c.String(maxLength: 128),
                        IdLinea = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Numero)
                .ForeignKey("dbo.Colors", t => t.CodigoColor)
                .ForeignKey("dbo.LineaDeProduccions", t => t.IdLinea, cascadeDelete: true)
                .ForeignKey("dbo.Modeloes", t => t.Sku)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CodigoColor)
                .Index(t => t.Sku)
                .Index(t => t.IdLinea)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        CodigoColor = c.String(nullable: false, maxLength: 128),
                        DescripcionColor = c.String(),
                    })
                .PrimaryKey(t => t.CodigoColor);
            
            CreateTable(
                "dbo.LineaDeProduccions",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        NumeroLinea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdLinea);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Sku = c.String(nullable: false, maxLength: 128),
                        Denominacion = c.String(),
                        LimiteInferiorDeObservado = c.Int(nullable: false),
                        LimiteInferiorDeReproceso = c.Int(nullable: false),
                        LimiteSuperiorDeObservado = c.Int(nullable: false),
                        LimiteSuperiorDeReproceso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sku);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Name = c.String(),
                        LastName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        IdTurno = c.Int(nullable: false, identity: true),
                        HoraDeInicio = c.Time(nullable: false, precision: 7),
                        HoraDeFin = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.IdTurno);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.JornadaLaborals", "IdTurno", "dbo.Turnoes");
            DropForeignKey("dbo.OrdenDeProduccions", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrdenDeProduccions", "Sku", "dbo.Modeloes");
            DropForeignKey("dbo.OrdenDeProduccions", "IdLinea", "dbo.LineaDeProduccions");
            DropForeignKey("dbo.JornadaLaborals", "Numero", "dbo.OrdenDeProduccions");
            DropForeignKey("dbo.OrdenDeProduccions", "CodigoColor", "dbo.Colors");
            DropForeignKey("dbo.HorarioDeControls", "IdJornada", "dbo.JornadaLaborals");
            DropForeignKey("dbo.Incidencias", "IdHorarioDeControl", "dbo.HorarioDeControls");
            DropForeignKey("dbo.Incidencias", "IdDefecto", "dbo.Defectoes");
            DropForeignKey("dbo.Alertas", "IdJornada", "dbo.JornadaLaborals");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.OrdenDeProduccions", new[] { "UserId" });
            DropIndex("dbo.OrdenDeProduccions", new[] { "IdLinea" });
            DropIndex("dbo.OrdenDeProduccions", new[] { "Sku" });
            DropIndex("dbo.OrdenDeProduccions", new[] { "CodigoColor" });
            DropIndex("dbo.Incidencias", new[] { "IdHorarioDeControl" });
            DropIndex("dbo.Incidencias", new[] { "IdDefecto" });
            DropIndex("dbo.HorarioDeControls", new[] { "IdJornada" });
            DropIndex("dbo.JornadaLaborals", new[] { "Numero" });
            DropIndex("dbo.JornadaLaborals", new[] { "IdTurno" });
            DropIndex("dbo.Alertas", new[] { "IdJornada" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Turnoes");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Modeloes");
            DropTable("dbo.LineaDeProduccions");
            DropTable("dbo.Colors");
            DropTable("dbo.OrdenDeProduccions");
            DropTable("dbo.Defectoes");
            DropTable("dbo.Incidencias");
            DropTable("dbo.HorarioDeControls");
            DropTable("dbo.JornadaLaborals");
            DropTable("dbo.Alertas");
        }
    }
}
