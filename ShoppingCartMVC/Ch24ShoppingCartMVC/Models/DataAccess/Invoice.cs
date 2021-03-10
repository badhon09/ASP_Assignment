
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Ch24ShoppingCartMVC.Models.DataAccess
{

using System;
    using System.Collections.Generic;
    
public partial class Invoice
{

    public Invoice()
    {

        this.LineItems = new HashSet<LineItem>();

    }


    public int InvoiceNumber { get; set; }

    public string CustEmail { get; set; }

    public System.DateTime OrderDate { get; set; }

    public decimal Subtotal { get; set; }

    public string ShipMethod { get; set; }

    public decimal Shipping { get; set; }

    public decimal SalesTax { get; set; }

    public decimal Total { get; set; }

    public string CreditCardType { get; set; }

    public string CardNumber { get; set; }

    public short ExpirationMonth { get; set; }

    public short ExpirationYear { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; }

}

}