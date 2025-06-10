using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Sweetened Snowflurry
	//甜蜜雪灵
	//[x]<b>Miniaturize</b><b>Battlecry:</b> Get 2 random<b>Temporary</b> Frost spells.
	//<b>微缩</b><b>战吼：</b>随机获取2张<b>临时</b>冰霜法术牌。
	class Sim_TOY_307 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 随机获取2张临时的冰霜法术牌
            for (int i = 0; i < 2; i++)
            {
                p.drawTemporaryCard(CardDB.cardIDEnum.None, own.own);
            }
        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果：抽一张衍生物牌
            CardDB.Card miniaturizedCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_307t); // 假设衍生物牌ID为 TOY_307t
            if (miniaturizedCard != null)
            {
                p.drawACard(miniaturizedCard.cardIDenum, ownplay, true);
            }
        }
    }
}
