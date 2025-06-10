using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：5
	//Woodland Wonders
	//林中奇遇
	//Summon two 2/5 Beetles with <b>Taunt</b>.Costs (3) less if you have <b>Spell Damage</b>.
	//召唤两只2/5并具有<b>嘲讽</b>的甲虫。如果你拥有<b>法术伤害</b>，本牌的法力值消耗减少（3）点。
	class Sim_TOY_804 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int cardCost = 5;

            // 如果拥有法术伤害，减少3点法力值消耗
            if (ownplay ? p.spellpower > 0 : p.enemyspellpower > 0)
            {
                cardCost -= 3;
            }

            // 扣除实际法力值消耗
            p.mana -= cardCost;

            // 召唤两只2/5并具有嘲讽的甲虫
            for (int i = 0; i < 2; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_804t), p.ownMinions.Count, ownplay);
            }
        }

    }
}
