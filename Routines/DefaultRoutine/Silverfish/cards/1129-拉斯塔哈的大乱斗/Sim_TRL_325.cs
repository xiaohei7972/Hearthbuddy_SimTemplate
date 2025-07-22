using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_325 : SimTemplate //* 鞭笞者苏萨斯 Sul'thraze
//<b>Overkill</b>: You may attack again.
//<b>超杀</b>：你可以再次攻击。 
    {

        

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_325);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
            
        }

    }

}