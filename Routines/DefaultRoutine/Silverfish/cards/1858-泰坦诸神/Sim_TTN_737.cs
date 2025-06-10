using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：8 攻击力：7 生命值：9
	//The Primus
	//兵主
	//<b>Titan</b>After this uses an ability, <b>Discover</b> a card with that Rune.
	//<b>泰坦</b>在本随从使用一个技能后，<b>发现</b>一张对应符文的牌。
	class Sim_TTN_737 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 鲜血符文
                    if (target != null)
                    {
                        p.minionGetDestroyed(target);
                        p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList().ForEach(m =>
                        {
                            m.Hp += target.Hp;
                        });
                        p.ownHero.Hp += target.Hp;
                        p.drawACard(CardDB.cardIDEnum.None, true, true);
                    }
                    break;

                case 2: // 邪恶符文
                    for (int i = 0; i < 2; i++)
                    {
                        p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_737t2), p.ownMinions.Count, true, false); // 召唤2个3/3并具有嘲讽和复生的亡灵
                    }
                    p.drawACard(CardDB.cardIDEnum.None, true, true);
                    break;

                case 3: // 冰霜符文
                    p.drawACard(CardDB.cardIDEnum.None, true, true);
                    break;

            }
        }
    }
}
