using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Etapa_3
{
    public class Entidad
    {
        private List<Persona> personas;
          
        public Entidad()
        {
            personas = new List<Persona>();

        }

        public Persona buscar(int id)
        {
            Persona busqueda = null;
            bool encontrar = false;

            for (int i = 0; i < personas.Count && encontrar == false; i++)
            {
                if (personas[i].getId() == id)
                {
                    busqueda = personas[i];
                    encontrar = true;
                }
            }

            return busqueda;
        }

        public void agregar(int id, String nombre, double peso, double altura)
        {
            Persona busqueda = buscar(id);
            if(busqueda == null)
            {
                Persona nuevo = new Persona(id, nombre, peso, altura);
                personas.Add(nuevo);
            }
        }

        public String calculaIMC(int id) 
        {
            Persona busqueda = buscar(id);
            String respuesta = null;
            if(busqueda != null)
            {
                double imc = busqueda.calcularIMC();

                if(imc < 18.5)
                {
                    respuesta = "IMC = " + imc + ". Estás bajo de peso"; 
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    respuesta = "IMC = " + imc + ". Estás en un rango normal de peso";
                }
                else if(imc >= 25 && imc < 30)
                {
                    respuesta = "IMC = " + imc + ". Estás en sobrepeso";
                }
                else if(imc >= 30)
                {
                    respuesta = "IMC = " + imc + ". Estás en obesidad";
                }
            }

            return respuesta;
        }
        


    }
}
