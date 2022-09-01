using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace MalinSpaceIPC
{

    [ServiceContract]
    internal interface IAstroContract
    {

        [OperationContract]
        double starVelocity(double observeWaveLenth, double restWaveLength);

        [OperationContract]
        double starDistance(double arcsecondsAngle);

        [OperationContract]
        double celciusToKelvin(double temperatureCelcius);

        [OperationContract]
        double eventHorizon(double M);
    }
}
