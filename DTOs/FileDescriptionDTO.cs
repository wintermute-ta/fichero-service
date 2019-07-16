﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveyor.DTOs
{
    public class FileDescriptionDTO
    {
        public string ContentDisposition { get; set; }
        public string ContentType { get; set; }
        public string DateUploaded { get; set; }

        public string FileName { get; set; }

        public string Guid { get; set; }

        public int Id { get; set; }
        public decimal SizeInKb { get; set; }
    }
}
