using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 牧师 费用：2
	//Thistle Tea Set
	//菊花茶具
	//<b>Discover</b> a spell from another class. Get a copy of it.
	//<b>发现</b>一张另一职业的法术牌，并获取一张它的复制。
	class Sim_TOY_514 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 假设在玩家选择卡牌后，它会被添加到 Hrtprozis.Instance.enchs 列表中
            if (Hrtprozis.Instance.enchs.Count > 0)
            {
                CardDB.cardIDEnum chosenCardID = Hrtprozis.Instance.enchs.LastOrDefault();

                // 添加选中的法术牌到手牌中
                p.drawACard(chosenCardID, ownplay, false); // 添加一张选中的法术牌
                p.drawACard(chosenCardID, ownplay, false); // 添加一张它的复制
            }
        }
    }
}
