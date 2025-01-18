
package parteAutoCR;


public class ClaseRepuestos {
//Declaracion de los atributos  del clase Repuestos

    private String nombreRepuesto;
    private String marcaRespuesto;
    private double precio;
    private double impuestos;
    private double precioSinImpuestos;
    private double precioConImpuestos;
    private String categoria;
    private int numeroRepuesto;
    private String rNombre;
    private String mRepuesto;
    private double precioRepuesto;
    private double impRepuesto;
    private double prcioRepstoSinImpuesto;
    private double prcioRepstoConImpuesto;
    private String catgRepuesto;
    

  
    //Constructor vacìo
   public ClaseRepuestos() {

        this.nombreRepuesto = "";
        this.marcaRespuesto = "";
        this.precioConImpuestos  = 0.0;
        this.precioSinImpuestos  = 0.0;
        this.precio  = 0.0;
        this.impuestos = 0.0;
        this.categoria = "";
        this.numeroRepuesto  = 0;
     
         
    }
  //Constructor para inicializar el objeto de la clase Repuestos/ sobrecargados
  public ClaseRepuestos(String rNombre, String mRepuesto, double precioRepuesto,double prcioRepstoConImpuesto, double prcioRepstoSinImpuesto, double impRepuesto, String catgRepuesto) {

        this.nombreRepuesto = rNombre;
        this.marcaRespuesto = mRepuesto;
        this.precioConImpuestos  = prcioRepstoConImpuesto;
        this.precioSinImpuestos  = prcioRepstoSinImpuesto;
        this.precio  = precioRepuesto;
        this.impuestos = impRepuesto;
        this.categoria = catgRepuesto;
        this.numeroRepuesto  = 0;
  }

    public String getNombreRepuesto() {
        return nombreRepuesto;
    }

    public void setNombreRepuesto(String nombreRepuesto) {
        this.nombreRepuesto = nombreRepuesto;
    }

    public String getMarcaRespuesto() {
        return marcaRespuesto;
    }

    public void setMarcaRespuesto(String marcaRespuesto) {
        this.marcaRespuesto = marcaRespuesto;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public double getImpuestos() {
        return impuestos;
    }

    public void setImpuestos(double impuestos) {
        this.impuestos = impuestos;
    }

    public double getPrecioSinImpuestos() {
        return precioSinImpuestos;
    }

    public void setPrecioSinImpuestos(double precioSinImpuestos) {
        this.precioSinImpuestos = precioSinImpuestos;
    }

    public double getPrecioConImpuestos() {
        return precioConImpuestos;
    }

    public void setPrecioConImpuestos(double precioConImpuestos) {
        this.precioConImpuestos = precioConImpuestos;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public int getNumeroRepuesto() {
        return numeroRepuesto;
    }

    public void setNumeroRepuesto(int numeroRepuesto) {
        this.numeroRepuesto = numeroRepuesto;
    }

    public String getrNombre() {
        return rNombre;
    }

    public void setrNombre(String rNombre) {
        this.rNombre = rNombre;
    }

    public String getmRepuesto() {
        return mRepuesto;
    }

    public void setmRepuesto(String mRepuesto) {
        this.mRepuesto = mRepuesto;
    }

    public double getPrecioRepuesto() {
        return precioRepuesto;
    }

    public void setPrecioRepuesto(double precioRepuesto) {
        this.precioRepuesto = precioRepuesto;
    }

    public double getImpRepuesto() {
        return impRepuesto;
    }

    public void setImpRepuesto(double impRepuesto) {
        this.impRepuesto = impRepuesto;
    }

    public double getPrcioRepstoSinImpuesto() {
        return prcioRepstoSinImpuesto;
    }

    public void setPrcioRepstoSinImpuesto(double prcioRepstoSinImpuesto) {
        this.prcioRepstoSinImpuesto = prcioRepstoSinImpuesto;
    }

    public double getPrcioRepstoConImpuesto() {
        return prcioRepstoConImpuesto;
    }

    public void setPrcioRepstoConImpuesto(double prcioRepstoConImpuesto) {
        this.prcioRepstoConImpuesto = prcioRepstoConImpuesto;
    }

    public String getCatgRepuesto() {
        return catgRepuesto;
    }

    public void setCatgRepuesto(String catgRepuesto) {
        this.catgRepuesto = catgRepuesto;
    }

    @Override
    public String toString() {
        return 
               " Numero de repuesto: # " + numeroRepuesto+ "\n"+
               " Nombre Respusto:" + nombreRepuesto + "\n"+
               " Marca Repuesto:" + marcaRespuesto+ "\n"+
               " Precio :  ¢ " + precio + "\n"+
               " Impuestos: ¢" + impuestos + "\n"+
               " Precio Sin Impuesto: ¢" + precioSinImpuestos + "\n"+
               " Precio Con Impuesto: ¢" + precioConImpuestos + "\n"+
               " Categorìa: " + categoria +
                "\n";
    

}
}
