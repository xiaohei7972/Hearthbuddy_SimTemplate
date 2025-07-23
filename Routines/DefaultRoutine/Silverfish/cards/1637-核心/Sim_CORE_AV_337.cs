using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：7 攻击力：5 生命值：6
	//Mountain Bear
	//山岭野熊
	//[x]<b>Taunt</b><b>Deathrattle:</b> Summon two2/4 Cubs with <b>Taunt</b>.
	//<b>嘲讽</b>，<b>亡语：</b>召唤两只2/4并具有<b>嘲讽</b>的山熊宝宝。
	class Sim_CORE_AV_337 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_337t);
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
            p.callKid(kid, m.zonepos - 1, m.own);
        }
		
	}
}
