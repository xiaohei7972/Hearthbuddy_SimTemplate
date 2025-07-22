using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_060 : SimTemplate //* 捕熊陷阱 Bear Trap
//<b>Secret:</b> After your hero is attacked, summon a 3/3 Bear with <b>Taunt</b>.
//<b>奥秘：</b>在你的英雄受到攻击后，召唤一个3/3并具有<b>嘲讽</b>的灰熊。 
	{
		

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_125);

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay);
        }
    }
}