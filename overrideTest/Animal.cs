using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideTest
{
    public class Animal
    {
        /// <summary>
        /// 動物類型
        /// </summary>
        public string kind { get; set; }
        /// <summary>
        /// 叫聲
        /// </summary>
        public string sound { get; set; }
        /// <summary>
        /// 發出叫聲
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        public virtual string MakeSound(string sound)
        {
            return kind + "發出的聲音:" + sound;
        }
    }
}
