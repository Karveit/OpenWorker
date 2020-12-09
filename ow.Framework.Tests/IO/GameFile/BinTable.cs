﻿using Microsoft.Extensions.DependencyInjection;
using ow.Framework.Game;
using Xunit;

namespace ow.Framework.Tests.IO.GameFile
{
    public class BinTableTest : IClassFixture<Startup>
    {
        private ServiceProvider _serviceProvider;
        private BinTable _binTableProcessor;

        public BinTableTest(Startup testSetup)
        {
            _serviceProvider = testSetup.ServiceProvider;
            _binTableProcessor = _serviceProvider.GetRequiredService<BinTable>();
        }

        [Fact]
        public void ReadClassSelectInfoTable()
        {
            _binTableProcessor.ReadClassSelectInfoTable();
        }

        [Fact]
        public void ReadCustomizeEyesTable()
        {
            _binTableProcessor.ReadCustomizeEyesTable();
        }

        [Fact]
        public void ReadCustomizeHairTable()
        {
            _binTableProcessor.ReadCustomizeHairTable();
        }

        [Fact]
        public void ReadCustomizeSkinTable()
        {
            _binTableProcessor.ReadCustomizeSkinTable();
        }

        [Fact]
        public void ReadDistrictTable()
        {
            _binTableProcessor.ReadDistrictTable();
        }

        [Fact]
        public void ReadItemTable()
        {
            _binTableProcessor.ReadItemTable();
        }
    }
}