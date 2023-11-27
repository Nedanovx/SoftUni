﻿using Boardgames.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Boardgame")]
    public class ImportBoardgameDto
    {
        [XmlElement("Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(10)]
        public string Name { get; set; }

        [XmlElement("Rating")]
        [Required]
        [Range(1.00, 10.00)]
        public double Rating { get; set; }

        [XmlElement("YearPublished")]
        [Required]
        [Range(2018, 2023)]
        public int YearPublished { get; set; }

        [XmlElement("CategoryType")]
        [Required]
        [Range(0, 4)]

        public int CategoryType { get; set; }

        [XmlElement("Mechanics")]
        [Required]
        public string Mechanics { get; set; } 
    }
}
