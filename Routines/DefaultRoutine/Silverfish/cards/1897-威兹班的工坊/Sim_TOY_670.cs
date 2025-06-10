using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：2 生命值：1
	//Giggling Toymaker
	//欢乐的玩具匠
	//<b>Deathrattle:</b> Summon two 1/2 Mechs with <b>Taunt</b> and <b>Divine Shield</b>.
	//<b>亡语：</b>召唤两个1/2并具有<b>嘲讽</b>和<b>圣盾</b>的机械。
	class Sim_TOY_670 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 召唤两个 1/2 并具有 嘲讽 和 圣盾 的机械
            for (int i = 0; i < 2; i++)
            {
                 p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BG_GVG_085), m.zonepos, m.own);
            }
        }

    }
}
