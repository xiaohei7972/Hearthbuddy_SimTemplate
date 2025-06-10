using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_400: SimTemplate //* 裂魂残像 Splitting Image
//<b>Secret:</b> When one of your minions is attacked, summon a copy of it.
//<b>奥秘：</b>当你的随从受到攻击时，召唤一个该随从的复制。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_170); 

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
        }
    }
}