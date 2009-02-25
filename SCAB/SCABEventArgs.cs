﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation version 3 of the License.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    
    Copyright Robert M. Meffe February 2009.
*/

namespace Crystalfontz.Modules
{
    public class CFATemperatureReportEventArgs : EventArgs
    {
        public CFATemperatureReportEventArgs()
        {
        }

        public CFATemperatureReportEventArgs(int SensorIndex, double TemperatureC, double TemperatureF)
        {
            this.SensorIndex = SensorIndex;
            this.TemperatureC = TemperatureC;
            this.TemperatureF = TemperatureF;
        }
        public double TemperatureC { get; set; }
        public double TemperatureF { get; set; }
        public int SensorIndex { get; set; }
    }

    public class CFAFanReportEventArgs : EventArgs
    {
        public CFAFanReportEventArgs()
        {
        }

        public CFAFanReportEventArgs(int Index,int Tachometer,int TimerTicks,int RPMS)
        {
            this.Index = Index;
            this.Tachometer = Tachometer;
            this.TimerTicks = TimerTicks;
            this.RPMS = RPMS;
        }

        public int Index { get; set; }
        public int Tachometer { get; set; }
        public int TimerTicks { get; set; }
        public int RPMS { get; set; }
    }
}
