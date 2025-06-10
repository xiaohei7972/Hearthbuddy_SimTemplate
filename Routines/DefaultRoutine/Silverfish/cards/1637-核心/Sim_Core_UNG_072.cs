using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：1 生命值：5
	//Stonehill Defender
	//石丘防御者
	//<b>Taunt</b><b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
	//<b>嘲讽</b>，<b>战吼：</b><b>发现</b>一张具有<b>嘲讽</b>的随从牌。
	class Sim_Core_UNG_072 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.pompousthespian, own.own, true);

        }
		
	}
}
