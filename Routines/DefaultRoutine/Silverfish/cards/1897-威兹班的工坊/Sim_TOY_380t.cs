using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：1 攻击力：1 生命值：1
	//Clay Matriarch
	//黏土巢母
	//[x]<b>Mini</b><b>Taunt</b>. <b>Deathrattle:</b> Summona 4/4 Whelp with <b>Elusive</b>.
	//<b>微型</b><b>嘲讽</b>。<b>亡语：</b>召唤一条4/4并具有<b>扰魔</b>的雏龙。
	class Sim_TOY_380t : SimTemplate
	{
        // 亡语效果
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 召唤一个 4/4 并具有“扰魔”的雏龙
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_380t2), m.zonepos, m.own);
        }
    }
}
