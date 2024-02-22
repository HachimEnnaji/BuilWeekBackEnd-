using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE_BW1_Ecommerce
{   
    //creo classe CartItem con proprietà Prodotto e Quantità
    public class CartItem
    {
        public Prodotto Prodotto { get; set; }
        public int Quantita { get; set; }

        public void IsEqualZero(int quantity)
        
        {
            Quantita = quantity;
            if (Quantita == 0)
                {
                Prodotto = null;
            }
        }
        
    }

    
}