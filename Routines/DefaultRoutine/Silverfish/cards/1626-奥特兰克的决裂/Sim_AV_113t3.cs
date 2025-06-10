using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_113t3 : SimTemplate //* 强化毒蛇陷阱 improvedsnaketrap
	{
        //<b>奥秘：</b>当你的随从受到攻击时，召唤三条2/2的蛇。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_113t3t2);//snake

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }

    }
}
