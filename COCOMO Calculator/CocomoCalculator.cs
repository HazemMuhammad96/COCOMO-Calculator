using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOMO_Calculator
{
    internal enum CostDrivers
    {
        //PRODUCT ATTR
        REQUIRED_SOFTWARE_RELIABILITY,
        SIZE_OF_APP_DATABASE,
        COMPLEXITY_OF_PRODUCT,
        //HARDWARE ATTR
        RUNTIME_PERFOMANCE_CONSTRAINTS,
        MEMORY_CONSTRAINTS,
        VOLATILITY_OF_VM_ENV,
        REQUIRED_TURNABOUT_TIME,
        //PERSONNAL ATTR
        ANALYST_CAPABILITY,
        APP_EXPERIENCE,
        SWE_CAPABILITY,
        VM_EXPERIENCE,
        PROGLANG_EXPERIENCE,
        //PROJECT ATTR
        APP_OF_SWE_METHODS,
        USE_OF_SW_TOOLS,
        REQUIRED_DEV_SCHEDULE,
    }

    internal class CocomoCalculator
    {
        private float kloc, eI, tDev, eAF, eFinal;

        private Dictionary<float, string> modelMinValues = new Dictionary<float, string>()
        {
            {2f, "organic" },
            {51f, "semidetached" },
            {301f,"embedded" },
        };
        
        private Dictionary<string, Dictionary<char, float>> modelValue = new Dictionary<string, Dictionary<char, float>>()
        {
            {
                "organic",
                new Dictionary<char, float>()
                {
                    {'a',3.2f },
                    {'b', 1.05f },
                    {'c',2.5f },
                    {'d',0.38f },
                }
            },
            {
                "semidetached",
                new Dictionary<char, float>()
                {
                    {'a',3.0f },
                    {'b', 1.12f },
                    {'c',2.5f },
                    {'d',0.35f },
                }
            },
            {
                "embedded",
                new Dictionary<char, float>()
                {
                    {'a',2.8f },
                    {'b', 1.2f },
                    {'c',2.5f },
                    {'d',0.32f },
                }
            },

        };


        private Dictionary<CostDrivers, Dictionary<string, float>> costDriverValues = new Dictionary<CostDrivers, Dictionary<string, float>>()
        {
            // Product Attr
            {
                CostDrivers.REQUIRED_SOFTWARE_RELIABILITY,
                new Dictionary<string, float>()
                {
                    {"vl", 0.75f},
                    {"l", 0.88f},
                    {"n", 1.0f },
                    {"h", 1.15f },
                    {"vh", 1.4f },
                }
            },
            {
                CostDrivers.SIZE_OF_APP_DATABASE,
                new Dictionary<string, float>()
                {
                    {"l", 0.94f},
                    {"n", 1.0f },
                    {"h", 1.08f },
                    {"vh", 1.16f },
                }
            },
            {
                CostDrivers.COMPLEXITY_OF_PRODUCT,
                new Dictionary<string, float>()
                {
                    {"vl", 0.7f },
                    {"l", 0.85f},
                    {"n", 1.0f },
                    {"h", 1.15f },
                    {"vh", 1.3f },
                    {"eh", 1.65f },
                }
            },
            // Hardware Attr
            {
                CostDrivers.RUNTIME_PERFOMANCE_CONSTRAINTS,
                new Dictionary<string, float>()
                {
                    
                    {"n", 1.0f },
                    {"h", 1.11f },
                    {"vh", 1.3f },
                    {"eh", 1.66f },
                }
            },
            {
                CostDrivers.MEMORY_CONSTRAINTS,
                new Dictionary<string, float>()
                {
                    {"n", 1.0f },
                    {"h", 1.06f },
                    {"vh", 1.21f },
                    {"eh", 1.56f },
                }
            },
            {
                CostDrivers.VOLATILITY_OF_VM_ENV,
                new Dictionary<string, float>()
                {
                    {"l", 0.87f},
                    {"n", 1.0f },
                    {"h", 1.15f },
                    {"vh", 1.3f },
                }
            },
            {
                CostDrivers.REQUIRED_TURNABOUT_TIME,
                new Dictionary<string, float>()
                {
                    {"l", 0.87f},
                    {"n", 1.0f },
                    {"h", 1.07f },
                    {"vh", 1.15f },
                }
            },
            // Personnal Attr
            {
                 CostDrivers.ANALYST_CAPABILITY,
                new Dictionary<string, float>()
                {
                    {"vl", 1.46f},
                    {"l", 1.19f },
                    {"n", 1.0f },
                    {"h", 0.86f },
                    {"vh", 0.71f },
                }
            },
            {
                CostDrivers.APP_EXPERIENCE,
                new Dictionary<string, float>()
                {
                    {"vl", 1.29f},
                    {"l", 1.13f },
                    {"n", 1.0f },
                    {"h", 0.91f },
                    {"vh", 0.82f },
                }
            },
            {
                CostDrivers.SWE_CAPABILITY,
                new Dictionary<string, float>()
                {
                    {"vl", 1.42f},
                    {"l", 1.17f },
                    {"n", 1.0f },
                    {"h", 0.86f },
                    {"vh", 0.70f },
                }
            },
            {
                CostDrivers.VM_EXPERIENCE,
                new Dictionary<string, float>()
                {
                    {"vl", 1.21f},
                    {"l", 1.10f },
                    {"n", 1.0f },
                    {"h", 0.90f },

                }
            },
            {
                CostDrivers.PROGLANG_EXPERIENCE,
                new Dictionary<string, float>()
                {
                    {"vl", 1.14f},
                    {"l", 1.07f },
                    {"n", 1.0f },
                    {"h", 0.95f },
                }
            },
            // Project Attr
            {
                CostDrivers.APP_OF_SWE_METHODS,
                new Dictionary<string, float>()
                {
                    {"vl", 1.24f},
                    {"l", 1.10f},
                    {"n", 1.0f },
                    {"h", 0.91f },
                    {"vh", 0.82f },
                }
            },
            {
                CostDrivers.USE_OF_SW_TOOLS,
                new Dictionary<string, float>()
                {
                    {"vl", 1.24f},
                    {"l", 1.10f},
                    {"n", 1.0f },
                    {"h", 0.91f },
                    {"vh", 0.83f },
                }
            },
            {
                CostDrivers.REQUIRED_DEV_SCHEDULE,
                new Dictionary<string, float>()
                {
                    {"vl", 1.23f},
                    {"l", 1.08f},
                    {"n", 1.0f },
                    {"h", 1.04f },
                    {"vh", 0.10f },
                }
            },

        };


        private Dictionary<char, float> usedModelValues = new Dictionary<char, float>();

        public CocomoCalculator(float kloc)
        {
            this.kloc = kloc;
            usedModelValues = getUsedModelValues();
            calculateEI();
        }

        public Dictionary<char, float> getUsedModelValues()
        {
            string modelName = ""; 
            foreach (var model in modelMinValues)
            {
                if (kloc > model.Key) modelName = model.Value; 
            }
            
            return modelValue[modelName];
        }

        public float calculateEI()
        {
            return (float)(
                usedModelValues['a'] * Math.Pow(kloc, usedModelValues['b'])
                );
        }

        public float calculateTDev()
        {

            return (float) (usedModelValues['c'] * Math.Pow(eFinal,usedModelValues['d']));
        }
        
        public float calculateEAF(Dictionary<CostDrivers, string> ratings)
        {
            float cost = 1;

            foreach(var rating in ratings)
            {
                cost *= costDriverValues[rating.Key][rating.Value];
            }

            return cost;
        }

        public void overrideUsedModel(string model)
        {
            if (model == "auto") return;
            else
                usedModelValues = modelValue[model];
        }

        public float calculateEFinal()
        {
            return eI * eAF;
        }

        public void initStep1()
        {
            eI = calculateEI();
            
        }

        public void initStep2(Dictionary<CostDrivers, string> ratings)
        {
            eAF = calculateEAF(ratings);
            eFinal = calculateEFinal();
            tDev = calculateTDev();
        }

        public void SetEI(float eI)
        {
            this.eI = eI;
        }

        public float GetEI() {
            return eI;
        }

        public float GetTDEV()
        {
            return tDev;
        }

        public float GetEAF()
        {
            return eAF;
        }

        public float GetEFinal()
        {
            return eFinal;
        }


    }
}
