﻿using Papu.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Papu.Models
{
    public class CreateProductDto
    {
        //Informacje, które może podać klient, aby stworzyć produkt

        //Nazwa produktu
        [Required]
        //Maksymalna długość łańcucha nazwy produktu wynosi 50
        [MaxLength(50)]
        public string ProductName { get; set; }

        //Nazwa kategorii
        //Maksymalna długość łańcucha nazwy kategorii wynosi 50
        [MaxLength(50)]
        public string CategoryName { get; set; }

        //Id grupy
        public int[] GroupId { get; set; }

        //Nazwa jednostki
        //Maksymalna długość łańcucha nazwy jednostki wynosi 50
        [MaxLength(50)]
        public string UnitName { get; set; }

        //Waga jednostki miary
        //Maksymalna długość łańcucha jednostki miary wynosi 4
        [Range(0, 9999, ErrorMessage = "Rating must between 0 to 9999")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Weight { get; set; }

        //Zdjęcie
        public string ProductImagePath { get; set; }
    }
}