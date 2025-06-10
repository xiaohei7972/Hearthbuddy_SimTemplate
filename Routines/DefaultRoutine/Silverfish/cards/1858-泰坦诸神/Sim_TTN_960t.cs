using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：11 攻击力：0 生命值：1
	//The Twisting Nether
	//扭曲虚空
	//At the end of your turn, summon two 3/2 Imps.
	//在你的回合结束时，召唤两个3/2的小鬼。
	class Sim_TTN_960t : SimTemplate
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t6);
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            p.callKid(kid, p.ownMinions.Count, true, false);
            p.callKid(kid, p.ownMinions.Count, true, false);
        }
    }
}
