using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Birdwatching
	//观赏鸟类
	//[x]<b>Discover</b> a minionfrom your deck. Give allcopies of it +2/+1<i>(wherever they are)</i>.
	//从你的牌库中<b>发现</b>一张随从牌。使其所有的复制获得+2/+1<i>（无论它们在哪）</i>。
	class Sim_VAC_408 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}
