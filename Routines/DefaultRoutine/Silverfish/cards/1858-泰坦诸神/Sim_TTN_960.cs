using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：9 攻击力：6 生命值：12
	//Sargeras, the Destroyer
	//灭世泰坦萨格拉斯
	//[x]<b>Titan</b><b>Battlecry:</b> Open a portalthat summons two 3/2Imps each turn.
	//<b>泰坦</b><b>战吼：</b>打开一道传送门，每回合召唤两个3/2的小鬼。
	class Sim_TTN_960 : SimTemplate
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, p.ownMinions.Count, true, false);
        }

        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 打入虚空！
                    p.ownMinions.Where(m => m.handcard.card.cardIDenum != CardDB.cardIDEnum.TTN_960).ToList().ForEach(m =>
                    {
                        p.RemoveMinionWithoutDeathrattle(m); // 送入扭曲虚空
                    });
                    p.enemyMinions.ForEach(m =>
                    {
                        p.RemoveMinionWithoutDeathrattle(m); // 送入扭曲虚空
                    });
                    break;

                case 2: // 地狱火！
                    for (int i = 0; i < 2; i++)
                    {
                        p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t5), p.ownMinions.Count, true, false); // 从扭曲虚空中召唤两个6/6的地狱火
                    }
                    break;

                case 3: // 军团进攻！
                    p.ownLegionInvasion = true;
                    break;

            }
        }
    }
}
