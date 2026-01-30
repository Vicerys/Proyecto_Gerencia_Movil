using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class Servicio
    {
        public DisponibilidadService Disponibilidad { get; set; }
        public EmpleadoService Empleado { get; set; }
        public EquipoService Equipo { get; set; }
        public EstadoService Estado { get; set; }
        public PuestoService Puesto { get; set; }
        public TareaEquipoService TareaEquipo { get; set; }
        public TareaService Tarea { get; set; }
        public InicioSesionService InicioSesion { get; set; }

        public Servicio(DisponibilidadService disponibilidad, EmpleadoService empleado, EquipoService equipo, EstadoService estado, PuestoService puesto, TareaEquipoService tareaEquipo, TareaService tarea, InicioSesionService inicioSesion) { 

            Disponibilidad = disponibilidad;
            Empleado = empleado;
            Equipo = equipo;
            Estado = estado;
            Puesto = puesto;
            TareaEquipo = tareaEquipo;
            Tarea = tarea;
            InicioSesion = inicioSesion;

        }
    }
}
