using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catalogo
{
    public partial class SiteMaster : MasterPage
    {
        Electrodomestico[] listaElec = new Electrodomestico[6];
        protected void Page_Load(object sender, EventArgs e)
        {
            Grafico.Visible = false;
            enlace.Visible = false;
            BotonCompra.Disabled=true; //desabilita el boton para que no sea presionado
            listaElec[0] = new Electrodomestico("000100","licuadora", "Licuadora 1.5 lt 10 velocidades", "Recco", 649f, "licuadora.jfif"); 
            listaElec[1] = new Electrodomestico("000101","lavadora", "Lavadora carga superior smart inverter con TurboDrum", "LG", 2169f, "lavadora.jfif");
            listaElec[2] = new Electrodomestico("000102","televisor", "Televisor Samsung UHD 58'' UN58AU7000GXPE", "Samsung", 3298f, "televisor.jfif");
            listaElec[3] = new Electrodomestico("000103","aspiradora", "Aspiradora 1400 W RASP-W017", "Recco", 119.90f, "aspiradora.jfif");
            listaElec[4] = new Electrodomestico("000104","plancha", "Plancha de Vapor Antiadherente", "Oster", 79f, "plancha.jfif");
            listaElec[5] = new Electrodomestico("000105","telefono", "Teléfono Motorola Auri3520 Blanco", "Motorola", 149f, "telefono.jfif");

        }
        protected void elegir_elec(Object sender, EventArgs argumentos)
        {
            BotonCompra.Disabled = false;
            BotonCompra.Style["background-color"] = "#FF9900";
            string nombre = Lista.Value.ToString();
            int i = 0;
            for (i=0;i<6 ;i++) {
                if (listaElec[i].getNombre() == nombre) {
                    break;                
                }
            }

            Grafico.Src = listaElec[i].getImg();
            Grafico.Alt = "Grafico Temperatura";
            Grafico.Visible = true;
            Label1.Text = "Codigo: " + listaElec[i].getCodigo();
            Label2.Text = "Nombre: "+listaElec[i].getNombre();
            Label3.Text = "Descripcion: " + listaElec[i].getDescripcion();
            Label4.Text = "Marca: " + listaElec[i].getMarca();
            Label5.Text = "Precio: S/" + listaElec[i].getPrecio().ToString();

        }
        private void mostrar()
        {

        }

    }
   
}

public class Electrodomestico
{
    String codigo;
    String nombre;
    String descripcion;
    String marca;
    float precio;
    String dir_img;

    public Electrodomestico(String cod, String nom, String desc, String marca, float pre, String dir)
    {
        this.codigo = cod;
        this.nombre = nom;
        this.descripcion = desc;
        this.marca = marca;
        this.precio = pre;
        this.dir_img = dir;
    }

    public String getNombre() {return this.nombre;}
    public String getCodigo() { return this.codigo; }
    public String getDescripcion() { return this.descripcion; }
    public String getMarca() { return this.marca; }
    public float getPrecio() { return this.precio; }
    public String getImg() { return this.dir_img; }


}
