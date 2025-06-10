using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_554 : SimTemplate //* 毒蛇陷阱 Snake Trap
	{
		//<b>Secret:</b> When one of your minions is attacked, summon three 1/1 Snakes.
		//<b>奥秘：</b>当你的随从受到攻击时，召唤三条1/1的蛇。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_554t);//snake

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }
	}
}