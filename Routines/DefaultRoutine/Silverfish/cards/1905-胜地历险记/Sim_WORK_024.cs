using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Handle with Bear
	//蛮熊搬家
	//[x]Get two 3/3 Bearswith <b>Taunt</b>. Each turnthey are in your hand,they gain +1/+1.
	//获取两张3/3并具有<b>嘲讽</b>的熊，其每在你手牌中一回合便获得+1/+1。
	class Sim_WORK_024 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.WORK_024t, m.own, true); 
            p.drawACard(CardDB.cardIDEnum.WORK_024t, m.own, true);
        }
		
	}
}
