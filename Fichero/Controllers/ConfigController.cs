﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fichero.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fichero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        public ConfigController(ApplicationConfig appConfig)
        {
            AppConfig = appConfig;
        }

        private ApplicationConfig AppConfig { get; }


        [HttpGet("[action]")]
        public double DataRetention()
        {
            return AppConfig.DataRetentionInDays;
        }
    }
}