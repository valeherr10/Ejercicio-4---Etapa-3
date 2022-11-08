using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Etapa_3
{
    public class Persona
    {
        private int id;
        private String nombre;
        private double peso;
        private double altura;

        public Persona (int id, String nombre, double peso, double altura)
        {
            this.id = id;
            this.nombre = nombre;
            this.peso = peso;
            this.altura = altura;
        }


        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        { 
            this.nombre = nombre;
        }

        public double getPeso()
        {
            return peso;
        }
        public void setPeso(double peso)
        {
            this.peso= peso;
        }

        public double getAltura()
        {
            return altura;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        override
        public String ToString()
        {
            return "Persona: " + "Identificación: " + id + "| Nombre: " + nombre + "| Peso: " + peso + "| Estatura: " + altura + "";
        }

        public double calcularIMC()
        {
            return ((peso)/(Math.Pow(altura,2)));
        }
    }
}
