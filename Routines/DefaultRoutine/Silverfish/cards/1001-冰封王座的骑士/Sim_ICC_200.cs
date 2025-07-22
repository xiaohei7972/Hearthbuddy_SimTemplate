using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_200: SimTemplate //* 眼镜蛇陷阱 Venomstrike Trap
//<b>Secret:</b> When one of your minions is attacked, summon a 2/3_<b>Poisonous</b> Cobra.
//<b>奥秘：</b>当你的随从受到攻击时，召唤一条2/3并具有<b>剧毒</b>的眼镜蛇。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_170); 

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
        }
    }
}