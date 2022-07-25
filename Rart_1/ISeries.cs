using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rart_1
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int startPoint;
        int result;
        public int GetNext()
        {
            result+=step;
            return result;
        }

        public void Reset()
        {
            result = startPoint;
        }

        public void SetStart(int x)
        {
            startPoint =x;
            result = startPoint;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }

    class GeomProgression : ISeries
    {
        int step;
        int startPoint;
        int result;
        public int GetNext()
        {
            result*=step;
            return result;
        }

        public void Reset()
        {
            result=startPoint;
        }

        public void SetStart(int x)
        {
            startPoint=x;
            result = startPoint;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
