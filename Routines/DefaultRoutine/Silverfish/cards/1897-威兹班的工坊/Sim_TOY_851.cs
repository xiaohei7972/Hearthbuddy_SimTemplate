using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Bottomless Toy Chest
	//无底玩具箱
	//<b>Discover</b> a card from your deck. If you have <b>Spell Damage</b>, copy it.
	//从你的牌库中<b>发现</b>一张牌。如果你拥有<b>法术伤害</b>，复制发现的牌。
	class Sim_TOY_851 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 发现的卡牌存储在 Hrtprozis.Instance.enchs 中
            if (Hrtprozis.Instance.enchs.Count > 0)
            {
                // 获取玩家发现的卡牌ID
                CardDB.cardIDEnum chosenCard = Hrtprozis.Instance.enchs.LastOrDefault(); // 假设玩家选择了第一张发现的卡牌

                // 将选择的卡牌添加到手牌中
                p.drawACard(chosenCard, ownplay, true);

                // 检查玩家是否拥有法术伤害，如果有，则复制该卡牌
                if (p.spellpower > 0)
                {
                    p.drawACard(chosenCard, ownplay, true);
                }
            }
        }

    }
}
