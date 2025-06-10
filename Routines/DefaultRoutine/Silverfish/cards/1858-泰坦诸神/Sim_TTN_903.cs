using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：10 攻击力：5 生命值：7
	//Eonar, the Life-Binder
	//生命的缚誓者艾欧娜尔
	//[x]<b>Titan</b>After this uses an ability,summon a 5/5 Ancientwith <b>Taunt</b>.
	//<b>泰坦</b>在本随从使用一个技能后，召唤一棵5/5并具有<b>嘲讽</b>的古树。
	class Sim_TTN_903 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 自行生长
                    while (p.owncards.Count < 10)
                    {
                        p.drawACard(CardDB.cardNameEN.unknown, true); // 抽牌直到手牌数量达到上限
                    }
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4), p.ownMinions.Count, true, false);
                    break;

                case 2: // 丰饶收获
                    p.ownHero.Hp = p.ownHero.maxHp; // 恢复所有生命值
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4), p.ownMinions.Count, true, false);
                    break;

                case 3: // 繁茂似锦
                    p.mana = p.ownMaxMana; // 复原法力水晶
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4), p.ownMinions.Count, true, false);
                    break;

            }
        }
    }
}
