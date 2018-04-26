using System;

namespace QzNetCore
{
    public class Q
    {
        public Q(){

        }
        private static Q __ = null;
        public static Q _(){
            if(__ == null){
                __ = new Q();
            }
            return __;
        }

        public string Uuid(){
            return Guid.NewGuid().ToString().Replace("-", "");
        }
        
    }
}
