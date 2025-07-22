using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_004 : SimTemplate //* 豹子戏法 Cat Trick
	{
		//<b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
		//<b>奥秘：</b>在你的对手施放一个法术后，召唤一只4/2并具有<b>潜行</b>的猎豹。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_004a);
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
        }
    }
}
