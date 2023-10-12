using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductoryExercises
{
    /// <summary>
    /// Person类
    /// </summary>
    [Serializable]
    public class Person
    {
        ///<summary>
        ///姓名
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        ///生日
        ///</summary>
        public DateTime Birthday { get; set; }

        ///<summary>
        ///性别
        ///</summary>
        public string Gender { get; set; }

        ///<summary>
        ///兴趣爱好
        ///</summary>
        public string Love {  get; set; }

    }
}
