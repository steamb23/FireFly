﻿// Copyright (c) 2017 SteamB23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFly.Modules
{
    public class DefaultGraphicsBaseModule : GraphicsBaseModule
    {
        Graphics.GraphicsDevice device;

        public DefaultGraphicsBaseModule(IntPtr windowsHandle)
        {
            device = new Graphics.GraphicsDevice(windowsHandle);
        }

        public override void Present()
        {
            device.Present();
        }
    }
}