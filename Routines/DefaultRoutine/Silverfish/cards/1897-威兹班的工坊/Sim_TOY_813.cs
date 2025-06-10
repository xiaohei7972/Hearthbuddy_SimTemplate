using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：5 攻击力：3 生命值：7
	//Toy Captain Tarim
	//玩具队长塔林姆
	//[x]<b>Miniaturize</b><b>Taunt</b>. <b>Battlecry:</b> Set aminion's Attack and Healthto this minion's.
	//<b>微缩</b><b>嘲讽</b>。<b>战吼：</b>将一个随从的攻击力和生命值变为与本随从相同。
	class Sim_TOY_813 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果，假设微缩效果是抽一张衍生物卡牌
            p.drawACard(CardDB.cardIDEnum.TOY_813t, ownplay, true); // 替换为实际的衍生物卡牌 ID

            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_813), p.ownMinions.Count, ownplay);
        }

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 执行战吼效果，将目标随从的攻击力和生命值设置为与本随从相同
            if (target != null)
            {
                p.minionSetAngrToX(target, own.Angr);
                p.minionSetLifetoX(target, own.Hp);
            }
        }


    }
}
