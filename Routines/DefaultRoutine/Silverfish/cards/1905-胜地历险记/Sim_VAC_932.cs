using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：6 攻击力：5 耐久度：2
	//Climbing Hook
	//登山钩爪
	//Doesn't lose Durability while you control a minion with 5 or more Attack.
	//当你控制着攻击力大于或等于5的随从时，不会失去耐久度。
	class Sim_VAC_932 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_932); // 获取武器卡牌数据
            p.equipWeapon(weapon, ownplay); // 装备登山钩爪
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            if (own.own)
            {
                bool hasStrongMinion = p.ownMinions.Exists(m => m.Angr >= 5); // 检查是否有攻击力大于或等于5的随从

                if (!hasStrongMinion)
                {
                    p.lowerWeaponDurability(1, true); // 如果没有符合条件的随从，则降低武器的耐久度
                }
            }
        }
    }
}
