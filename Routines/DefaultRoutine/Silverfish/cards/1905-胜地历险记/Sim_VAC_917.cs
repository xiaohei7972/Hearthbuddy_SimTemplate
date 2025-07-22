using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：3 生命值：4
	//Grillmaster
	//烧烤大师
	//[x]<b>Battlecry:</b> Draw yourlowest Cost card.<b>Deathrattle:</b> Draw yourhighest Cost card.
	//<b>战吼：</b>抽取你法力值消耗最低的牌。<b>亡语：</b>抽取你法力值消耗最高的牌。
	class Sim_VAC_917 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 战吼：抽一张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 亡语：抽一张牌
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}
