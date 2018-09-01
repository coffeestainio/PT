﻿using System;
using System.Collections.Generic;

namespace FacElec.model
{
    public class factura_Detalle
    {
        
        public string Id_Producto;
        public decimal cantidad;
        public int unidad;
        public int id_factura;
        public decimal precio;
        public decimal descuento;
        public bool IV;
        public List<producto> producto;

        public factura_Detalle(string id_Producto, decimal cantidad, int unidad, int id_factura, decimal precio, decimal descuento, bool iV , List<producto> producto)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
            this.id_factura = id_factura;
            this.precio = precio;
            this.descuento = descuento;
            IV = iV;
            this.producto = producto;
            this.Id_Producto = id_Producto;
        }
    }
}
