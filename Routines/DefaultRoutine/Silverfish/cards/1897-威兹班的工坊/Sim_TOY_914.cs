using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：8 攻击力：4 生命值：4
	//Wretched Queen
	//邪鬼皇后
	//[x]<b>Taunt</b><b>Deathrattle:</b> Summon two4/6 Knights with <b>Taunt</b>.
	//<b>嘲讽</b><b>亡语：</b>召唤两个4/6并具有<b>嘲讽</b>的骑士。
	class Sim_TOY_914 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 召唤两个4/6并具有嘲讽的骑士
            for (int i = 0; i < 2; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_914t), m.zonepos, m.own);
            }
        }


    }
}
