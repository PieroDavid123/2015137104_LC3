namespace LineaTelefonica.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departamento", "Ubigeo_UbigeoId", "dbo.Ubigeo");
            DropForeignKey("dbo.Distrito", "Ubigeo_UbigeoId", "dbo.Ubigeo");
            DropForeignKey("dbo.Provincia", "Ubigeo_UbigeoId", "dbo.Ubigeo");
            DropForeignKey("dbo.EquipoCelular", "AdministradorEquipo_AdministradorEquipoId", "dbo.AdministradorEquipo");
            DropForeignKey("dbo.Venta", "Evaluacion_EvaluacionId", "dbo.Evaluacion");
            DropForeignKey("dbo.LineaTelefonica", "AdministradorLinea_AdministradorLineaId", "dbo.AdministradorLinea");
            DropForeignKey("dbo.Venta", "LineaTelefonica_LineaTelefonicaId", "dbo.LineaTelefonica");
            DropForeignKey("dbo.Evaluacion", "CentroAtencion_CentroAtencionId", "dbo.CentroAtencion");
            DropForeignKey("dbo.Evaluacion", "Plan_PlanId", "dbo.Plan");
            DropForeignKey("dbo.Plan", "TipoPlan_TipoPlanId", "dbo.TipoPlan");
            DropForeignKey("dbo.Evaluacion", "Trabajador_TrabajadorId", "dbo.Trabajador");
            DropForeignKey("dbo.Evaluacion", "EstadoEvaluacion_EstadoEvaluacionId", "dbo.EstadoEvaluacion");
            DropForeignKey("dbo.Evaluacion", "TipoEvaluacion_TipoEvaluacionId", "dbo.TipoEvaluacion");
            DropForeignKey("dbo.LineaTelefonica", "TipoLinea_TipoLineaId", "dbo.TipoLinea");
            DropForeignKey("dbo.Venta", "TipoPago_TipoPagoId", "dbo.TipoPago");
            DropForeignKey("dbo.Trabajador", "TipoTrabajador_TipoTrabajadorId", "dbo.TipoTrabajador");
            DropIndex("dbo.EquipoCelular", new[] { "AdministradorEquipo_AdministradorEquipoId" });
            DropIndex("dbo.Evaluacion", new[] { "LineaTelefonica_LineaTelefonicaId" });
            DropIndex("dbo.Evaluacion", new[] { "CentroAtencion_CentroAtencionId" });
            DropIndex("dbo.Evaluacion", new[] { "Plan_PlanId" });
            DropIndex("dbo.Evaluacion", new[] { "Trabajador_TrabajadorId" });
            DropIndex("dbo.Evaluacion", new[] { "EstadoEvaluacion_EstadoEvaluacionId" });
            DropIndex("dbo.Evaluacion", new[] { "TipoEvaluacion_TipoEvaluacionId" });
            DropIndex("dbo.Venta", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.Venta", new[] { "LineaTelefonica_LineaTelefonicaId" });
            DropIndex("dbo.Venta", new[] { "CentroAtencion_CentroAtencionId" });
            DropIndex("dbo.Venta", new[] { "Trabajador_TrabajadorId" });
            DropIndex("dbo.Venta", new[] { "TipoPago_TipoPagoId" });
            DropIndex("dbo.LineaTelefonica", new[] { "AdministradorLinea_AdministradorLineaId" });
            DropIndex("dbo.LineaTelefonica", new[] { "TipoLinea_TipoLineaId" });
            DropIndex("dbo.Departamento", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Provincia", new[] { "Departamento_DepartamentoId" });
            DropIndex("dbo.Provincia", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Distrito", new[] { "Provincia_ProvinciaId" });
            DropIndex("dbo.Distrito", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Plan", new[] { "TipoPlan_TipoPlanId" });
            DropIndex("dbo.Trabajador", new[] { "TipoTrabajador_TipoTrabajadorId" });
            RenameColumn(table: "dbo.EquipoCelular", name: "AdministradorEquipo_AdministradorEquipoId", newName: "AdministradorEquipoId");
            RenameColumn(table: "dbo.Venta", name: "Evaluacion_EvaluacionId", newName: "EvaluacionId");
            RenameColumn(table: "dbo.LineaTelefonica", name: "AdministradorLinea_AdministradorLineaId", newName: "AdministradorLineaId");
            RenameColumn(table: "dbo.Venta", name: "LineaTelefonica_LineaTelefonicaId", newName: "LineaTelefonicaId");
            RenameColumn(table: "dbo.Evaluacion", name: "LineaTelefonica_LineaTelefonicaId", newName: "LineaTelefonicaId");
            RenameColumn(table: "dbo.Evaluacion", name: "CentroAtencion_CentroAtencionId", newName: "CentroAtencionId");
            RenameColumn(table: "dbo.Provincia", name: "Departamento_DepartamentoId", newName: "DepartamentoId");
            RenameColumn(table: "dbo.Distrito", name: "Provincia_ProvinciaId", newName: "ProvinciaId");
            RenameColumn(table: "dbo.Evaluacion", name: "Plan_PlanId", newName: "PlanId");
            RenameColumn(table: "dbo.Plan", name: "TipoPlan_TipoPlanId", newName: "TipoPlanId");
            RenameColumn(table: "dbo.Evaluacion", name: "Trabajador_TrabajadorId", newName: "TrabajadorId");
            RenameColumn(table: "dbo.Venta", name: "Trabajador_TrabajadorId", newName: "TrabajadorId");
            RenameColumn(table: "dbo.Evaluacion", name: "EstadoEvaluacion_EstadoEvaluacionId", newName: "EstadoEvaluacionId");
            RenameColumn(table: "dbo.Evaluacion", name: "TipoEvaluacion_TipoEvaluacionId", newName: "TipoEvaluacionId");
            RenameColumn(table: "dbo.LineaTelefonica", name: "TipoLinea_TipoLineaId", newName: "TipoLineaId");
            RenameColumn(table: "dbo.Venta", name: "TipoPago_TipoPagoId", newName: "TipoPagoId");
            RenameColumn(table: "dbo.Trabajador", name: "TipoTrabajador_TipoTrabajadorId", newName: "TipoTrabajadorId");
            RenameColumn(table: "dbo.Venta", name: "CentroAtencion_CentroAtencionId", newName: "CentroAtencionId");
            AddColumn("dbo.Contrato", "NumeroContrato", c => c.String());
            AddColumn("dbo.Ubigeo", "DepartamentoId", c => c.Int(nullable: false));
            AddColumn("dbo.Ubigeo", "ProvinciaId", c => c.Int(nullable: false));
            AddColumn("dbo.Ubigeo", "DistritoId", c => c.Int(nullable: false));
            AlterColumn("dbo.EquipoCelular", "AdministradorEquipoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "LineaTelefonicaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "CentroAtencionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "PlanId", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "TrabajadorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "EstadoEvaluacionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "TipoEvaluacionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venta", "EvaluacionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venta", "LineaTelefonicaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venta", "CentroAtencionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venta", "TrabajadorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venta", "TipoPagoId", c => c.Int(nullable: false));
            AlterColumn("dbo.LineaTelefonica", "AdministradorLineaId", c => c.Int(nullable: false));
            AlterColumn("dbo.LineaTelefonica", "TipoLineaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Provincia", "DepartamentoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Distrito", "ProvinciaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Plan", "TipoPlanId", c => c.Int(nullable: false));
            AlterColumn("dbo.Trabajador", "TipoTrabajadorId", c => c.Int(nullable: false));
            CreateIndex("dbo.EquipoCelular", "AdministradorEquipoId");
            CreateIndex("dbo.Evaluacion", "TipoEvaluacionId");
            CreateIndex("dbo.Evaluacion", "EstadoEvaluacionId");
            CreateIndex("dbo.Evaluacion", "CentroAtencionId");
            CreateIndex("dbo.Evaluacion", "LineaTelefonicaId");
            CreateIndex("dbo.Evaluacion", "PlanId");
            CreateIndex("dbo.Evaluacion", "TrabajadorId");
            CreateIndex("dbo.Venta", "CentroAtencionId");
            CreateIndex("dbo.Venta", "EvaluacionId");
            CreateIndex("dbo.Venta", "LineaTelefonicaId");
            CreateIndex("dbo.Venta", "TipoPagoId");
            CreateIndex("dbo.Venta", "TrabajadorId");
            CreateIndex("dbo.LineaTelefonica", "AdministradorLineaId");
            CreateIndex("dbo.LineaTelefonica", "TipoLineaId");
            CreateIndex("dbo.Trabajador", "TipoTrabajadorId");
            CreateIndex("dbo.Plan", "TipoPlanId");
            CreateIndex("dbo.Provincia", "DepartamentoId");
            CreateIndex("dbo.Distrito", "ProvinciaId");
            CreateIndex("dbo.Ubigeo", "DepartamentoId");
            CreateIndex("dbo.Ubigeo", "ProvinciaId");
            CreateIndex("dbo.Ubigeo", "DistritoId");
            AddForeignKey("dbo.Ubigeo", "DepartamentoId", "dbo.Departamento", "DepartamentoId", cascadeDelete: true);
            AddForeignKey("dbo.Ubigeo", "DistritoId", "dbo.Distrito", "DistritoId", cascadeDelete: true);
            AddForeignKey("dbo.Ubigeo", "ProvinciaId", "dbo.Provincia", "ProvinciaId", cascadeDelete: true);
            AddForeignKey("dbo.EquipoCelular", "AdministradorEquipoId", "dbo.AdministradorEquipo", "AdministradorEquipoId", cascadeDelete: true);
            AddForeignKey("dbo.Venta", "EvaluacionId", "dbo.Evaluacion", "EvaluacionId", cascadeDelete: true);
            AddForeignKey("dbo.LineaTelefonica", "AdministradorLineaId", "dbo.AdministradorLinea", "AdministradorLineaId", cascadeDelete: true);
            AddForeignKey("dbo.Venta", "LineaTelefonicaId", "dbo.LineaTelefonica", "LineaTelefonicaId", cascadeDelete: true);
            AddForeignKey("dbo.Evaluacion", "CentroAtencionId", "dbo.CentroAtencion", "CentroAtencionId", cascadeDelete: true);
            AddForeignKey("dbo.Evaluacion", "PlanId", "dbo.Plan", "PlanId", cascadeDelete: true);
            AddForeignKey("dbo.Plan", "TipoPlanId", "dbo.TipoPlan", "TipoPlanId", cascadeDelete: true);
            AddForeignKey("dbo.Evaluacion", "TrabajadorId", "dbo.Trabajador", "TrabajadorId", cascadeDelete: true);
            AddForeignKey("dbo.Evaluacion", "EstadoEvaluacionId", "dbo.EstadoEvaluacion", "EstadoEvaluacionId", cascadeDelete: true);
            AddForeignKey("dbo.Evaluacion", "TipoEvaluacionId", "dbo.TipoEvaluacion", "TipoEvaluacionId", cascadeDelete: true);
            AddForeignKey("dbo.LineaTelefonica", "TipoLineaId", "dbo.TipoLinea", "TipoLineaId", cascadeDelete: true);
            AddForeignKey("dbo.Venta", "TipoPagoId", "dbo.TipoPago", "TipoPagoId", cascadeDelete: true);
            AddForeignKey("dbo.Trabajador", "TipoTrabajadorId", "dbo.TipoTrabajador", "TipoTrabajadorId", cascadeDelete: true);
            DropColumn("dbo.Contrato", "_NumeroContrato");
            DropColumn("dbo.Departamento", "Ubigeo_UbigeoId");
            DropColumn("dbo.Provincia", "Ubigeo_UbigeoId");
            DropColumn("dbo.Distrito", "Ubigeo_UbigeoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Distrito", "Ubigeo_UbigeoId", c => c.Int());
            AddColumn("dbo.Provincia", "Ubigeo_UbigeoId", c => c.Int());
            AddColumn("dbo.Departamento", "Ubigeo_UbigeoId", c => c.Int());
            AddColumn("dbo.Contrato", "_NumeroContrato", c => c.String());
            DropForeignKey("dbo.Trabajador", "TipoTrabajadorId", "dbo.TipoTrabajador");
            DropForeignKey("dbo.Venta", "TipoPagoId", "dbo.TipoPago");
            DropForeignKey("dbo.LineaTelefonica", "TipoLineaId", "dbo.TipoLinea");
            DropForeignKey("dbo.Evaluacion", "TipoEvaluacionId", "dbo.TipoEvaluacion");
            DropForeignKey("dbo.Evaluacion", "EstadoEvaluacionId", "dbo.EstadoEvaluacion");
            DropForeignKey("dbo.Evaluacion", "TrabajadorId", "dbo.Trabajador");
            DropForeignKey("dbo.Plan", "TipoPlanId", "dbo.TipoPlan");
            DropForeignKey("dbo.Evaluacion", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.Evaluacion", "CentroAtencionId", "dbo.CentroAtencion");
            DropForeignKey("dbo.Venta", "LineaTelefonicaId", "dbo.LineaTelefonica");
            DropForeignKey("dbo.LineaTelefonica", "AdministradorLineaId", "dbo.AdministradorLinea");
            DropForeignKey("dbo.Venta", "EvaluacionId", "dbo.Evaluacion");
            DropForeignKey("dbo.EquipoCelular", "AdministradorEquipoId", "dbo.AdministradorEquipo");
            DropForeignKey("dbo.Ubigeo", "ProvinciaId", "dbo.Provincia");
            DropForeignKey("dbo.Ubigeo", "DistritoId", "dbo.Distrito");
            DropForeignKey("dbo.Ubigeo", "DepartamentoId", "dbo.Departamento");
            DropIndex("dbo.Ubigeo", new[] { "DistritoId" });
            DropIndex("dbo.Ubigeo", new[] { "ProvinciaId" });
            DropIndex("dbo.Ubigeo", new[] { "DepartamentoId" });
            DropIndex("dbo.Distrito", new[] { "ProvinciaId" });
            DropIndex("dbo.Provincia", new[] { "DepartamentoId" });
            DropIndex("dbo.Plan", new[] { "TipoPlanId" });
            DropIndex("dbo.Trabajador", new[] { "TipoTrabajadorId" });
            DropIndex("dbo.LineaTelefonica", new[] { "TipoLineaId" });
            DropIndex("dbo.LineaTelefonica", new[] { "AdministradorLineaId" });
            DropIndex("dbo.Venta", new[] { "TrabajadorId" });
            DropIndex("dbo.Venta", new[] { "TipoPagoId" });
            DropIndex("dbo.Venta", new[] { "LineaTelefonicaId" });
            DropIndex("dbo.Venta", new[] { "EvaluacionId" });
            DropIndex("dbo.Venta", new[] { "CentroAtencionId" });
            DropIndex("dbo.Evaluacion", new[] { "TrabajadorId" });
            DropIndex("dbo.Evaluacion", new[] { "PlanId" });
            DropIndex("dbo.Evaluacion", new[] { "LineaTelefonicaId" });
            DropIndex("dbo.Evaluacion", new[] { "CentroAtencionId" });
            DropIndex("dbo.Evaluacion", new[] { "EstadoEvaluacionId" });
            DropIndex("dbo.Evaluacion", new[] { "TipoEvaluacionId" });
            DropIndex("dbo.EquipoCelular", new[] { "AdministradorEquipoId" });
            AlterColumn("dbo.Trabajador", "TipoTrabajadorId", c => c.Int());
            AlterColumn("dbo.Plan", "TipoPlanId", c => c.Int());
            AlterColumn("dbo.Distrito", "ProvinciaId", c => c.Int());
            AlterColumn("dbo.Provincia", "DepartamentoId", c => c.Int());
            AlterColumn("dbo.LineaTelefonica", "TipoLineaId", c => c.Int());
            AlterColumn("dbo.LineaTelefonica", "AdministradorLineaId", c => c.Int());
            AlterColumn("dbo.Venta", "TipoPagoId", c => c.Int());
            AlterColumn("dbo.Venta", "TrabajadorId", c => c.Int());
            AlterColumn("dbo.Venta", "CentroAtencionId", c => c.Int());
            AlterColumn("dbo.Venta", "LineaTelefonicaId", c => c.Int());
            AlterColumn("dbo.Venta", "EvaluacionId", c => c.Int());
            AlterColumn("dbo.Evaluacion", "TipoEvaluacionId", c => c.Int());
            AlterColumn("dbo.Evaluacion", "EstadoEvaluacionId", c => c.Int());
            AlterColumn("dbo.Evaluacion", "TrabajadorId", c => c.Int());
            AlterColumn("dbo.Evaluacion", "PlanId", c => c.Int());
            AlterColumn("dbo.Evaluacion", "CentroAtencionId", c => c.Int());
            AlterColumn("dbo.Evaluacion", "LineaTelefonicaId", c => c.Int());
            AlterColumn("dbo.EquipoCelular", "AdministradorEquipoId", c => c.Int());
            DropColumn("dbo.Ubigeo", "DistritoId");
            DropColumn("dbo.Ubigeo", "ProvinciaId");
            DropColumn("dbo.Ubigeo", "DepartamentoId");
            DropColumn("dbo.Contrato", "NumeroContrato");
            RenameColumn(table: "dbo.Venta", name: "CentroAtencionId", newName: "CentroAtencion_CentroAtencionId");
            RenameColumn(table: "dbo.Trabajador", name: "TipoTrabajadorId", newName: "TipoTrabajador_TipoTrabajadorId");
            RenameColumn(table: "dbo.Venta", name: "TipoPagoId", newName: "TipoPago_TipoPagoId");
            RenameColumn(table: "dbo.LineaTelefonica", name: "TipoLineaId", newName: "TipoLinea_TipoLineaId");
            RenameColumn(table: "dbo.Evaluacion", name: "TipoEvaluacionId", newName: "TipoEvaluacion_TipoEvaluacionId");
            RenameColumn(table: "dbo.Evaluacion", name: "EstadoEvaluacionId", newName: "EstadoEvaluacion_EstadoEvaluacionId");
            RenameColumn(table: "dbo.Venta", name: "TrabajadorId", newName: "Trabajador_TrabajadorId");
            RenameColumn(table: "dbo.Evaluacion", name: "TrabajadorId", newName: "Trabajador_TrabajadorId");
            RenameColumn(table: "dbo.Plan", name: "TipoPlanId", newName: "TipoPlan_TipoPlanId");
            RenameColumn(table: "dbo.Evaluacion", name: "PlanId", newName: "Plan_PlanId");
            RenameColumn(table: "dbo.Distrito", name: "ProvinciaId", newName: "Provincia_ProvinciaId");
            RenameColumn(table: "dbo.Provincia", name: "DepartamentoId", newName: "Departamento_DepartamentoId");
            RenameColumn(table: "dbo.Evaluacion", name: "CentroAtencionId", newName: "CentroAtencion_CentroAtencionId");
            RenameColumn(table: "dbo.Evaluacion", name: "LineaTelefonicaId", newName: "LineaTelefonica_LineaTelefonicaId");
            RenameColumn(table: "dbo.Venta", name: "LineaTelefonicaId", newName: "LineaTelefonica_LineaTelefonicaId");
            RenameColumn(table: "dbo.LineaTelefonica", name: "AdministradorLineaId", newName: "AdministradorLinea_AdministradorLineaId");
            RenameColumn(table: "dbo.Venta", name: "EvaluacionId", newName: "Evaluacion_EvaluacionId");
            RenameColumn(table: "dbo.EquipoCelular", name: "AdministradorEquipoId", newName: "AdministradorEquipo_AdministradorEquipoId");
            CreateIndex("dbo.Trabajador", "TipoTrabajador_TipoTrabajadorId");
            CreateIndex("dbo.Plan", "TipoPlan_TipoPlanId");
            CreateIndex("dbo.Distrito", "Ubigeo_UbigeoId");
            CreateIndex("dbo.Distrito", "Provincia_ProvinciaId");
            CreateIndex("dbo.Provincia", "Ubigeo_UbigeoId");
            CreateIndex("dbo.Provincia", "Departamento_DepartamentoId");
            CreateIndex("dbo.Departamento", "Ubigeo_UbigeoId");
            CreateIndex("dbo.LineaTelefonica", "TipoLinea_TipoLineaId");
            CreateIndex("dbo.LineaTelefonica", "AdministradorLinea_AdministradorLineaId");
            CreateIndex("dbo.Venta", "TipoPago_TipoPagoId");
            CreateIndex("dbo.Venta", "Trabajador_TrabajadorId");
            CreateIndex("dbo.Venta", "CentroAtencion_CentroAtencionId");
            CreateIndex("dbo.Venta", "LineaTelefonica_LineaTelefonicaId");
            CreateIndex("dbo.Venta", "Evaluacion_EvaluacionId");
            CreateIndex("dbo.Evaluacion", "TipoEvaluacion_TipoEvaluacionId");
            CreateIndex("dbo.Evaluacion", "EstadoEvaluacion_EstadoEvaluacionId");
            CreateIndex("dbo.Evaluacion", "Trabajador_TrabajadorId");
            CreateIndex("dbo.Evaluacion", "Plan_PlanId");
            CreateIndex("dbo.Evaluacion", "CentroAtencion_CentroAtencionId");
            CreateIndex("dbo.Evaluacion", "LineaTelefonica_LineaTelefonicaId");
            CreateIndex("dbo.EquipoCelular", "AdministradorEquipo_AdministradorEquipoId");
            AddForeignKey("dbo.Trabajador", "TipoTrabajador_TipoTrabajadorId", "dbo.TipoTrabajador", "TipoTrabajadorId");
            AddForeignKey("dbo.Venta", "TipoPago_TipoPagoId", "dbo.TipoPago", "TipoPagoId");
            AddForeignKey("dbo.LineaTelefonica", "TipoLinea_TipoLineaId", "dbo.TipoLinea", "TipoLineaId");
            AddForeignKey("dbo.Evaluacion", "TipoEvaluacion_TipoEvaluacionId", "dbo.TipoEvaluacion", "TipoEvaluacionId");
            AddForeignKey("dbo.Evaluacion", "EstadoEvaluacion_EstadoEvaluacionId", "dbo.EstadoEvaluacion", "EstadoEvaluacionId");
            AddForeignKey("dbo.Evaluacion", "Trabajador_TrabajadorId", "dbo.Trabajador", "TrabajadorId");
            AddForeignKey("dbo.Plan", "TipoPlan_TipoPlanId", "dbo.TipoPlan", "TipoPlanId");
            AddForeignKey("dbo.Evaluacion", "Plan_PlanId", "dbo.Plan", "PlanId");
            AddForeignKey("dbo.Evaluacion", "CentroAtencion_CentroAtencionId", "dbo.CentroAtencion", "CentroAtencionId");
            AddForeignKey("dbo.Venta", "LineaTelefonica_LineaTelefonicaId", "dbo.LineaTelefonica", "LineaTelefonicaId");
            AddForeignKey("dbo.LineaTelefonica", "AdministradorLinea_AdministradorLineaId", "dbo.AdministradorLinea", "AdministradorLineaId");
            AddForeignKey("dbo.Venta", "Evaluacion_EvaluacionId", "dbo.Evaluacion", "EvaluacionId");
            AddForeignKey("dbo.EquipoCelular", "AdministradorEquipo_AdministradorEquipoId", "dbo.AdministradorEquipo", "AdministradorEquipoId");
            AddForeignKey("dbo.Provincia", "Ubigeo_UbigeoId", "dbo.Ubigeo", "UbigeoId");
            AddForeignKey("dbo.Distrito", "Ubigeo_UbigeoId", "dbo.Ubigeo", "UbigeoId");
            AddForeignKey("dbo.Departamento", "Ubigeo_UbigeoId", "dbo.Ubigeo", "UbigeoId");
        }
    }
}