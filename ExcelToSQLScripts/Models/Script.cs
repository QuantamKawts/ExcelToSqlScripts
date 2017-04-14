﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExcelToSQLScripts.Models
{
    public class Script : IDisposable
    {
        public Script(string name, Stream content)
        {
            Name = name;
            Content = content;
        }

        public string Name { get; set; }

        public Stream Content { get; set; }

        public void Dispose()
        {
            Content?.Dispose();
        }
    }
}