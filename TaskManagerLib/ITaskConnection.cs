﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CX.TaskManagerLib
{
    public interface ITaskConnection
    {
        public string TaskDataStorageLocation { get; }
    }
}