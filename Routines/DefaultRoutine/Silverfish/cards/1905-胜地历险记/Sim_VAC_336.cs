using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：6 生命值：5
	//Maestra, Mask Merchant
	//面具变装大师
	//[x]<b>Warlock Tourist</b><b><b>Battlecry:</b> Discover</b> aHero card from the past<i>(from another class)</i>.
	//<b>术士游客</b><b><b>战吼：</b>发现</b>一张来自过去的<i>（另一职业的）</i>英雄牌。
	class Sim_VAC_336 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 发现一张来自过去的（另一职业的）英雄牌
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}
