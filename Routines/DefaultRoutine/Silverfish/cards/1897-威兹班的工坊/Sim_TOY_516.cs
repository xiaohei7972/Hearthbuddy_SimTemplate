using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：3 攻击力：3 生命值：2
	//Bargain Bin Buccaneer
	//折价区海盗
	//<b>Rush</b><b>Combo:</b> Summon acopy of this.
	//<b>突袭</b>。<b>连击：</b>召唤一个本随从的复制。
	class Sim_TOY_516 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 检查是否触发了连击效果
            if (p.cardsPlayedThisTurn > 0) // 连击：本回合是否已经打出了其他卡牌
            {
                if (p.ownMinions.Count < 7) // 确保场上有空位
                {
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_516), p.ownMinions.Count, ownplay);
                    Minion copy = p.ownMinions[p.ownMinions.Count - 1];

                    // 复制所有关键属性
                    copy.Angr = target.Angr;
                    copy.Hp = target.Hp;
                    copy.maxHp = target.maxHp;
                    copy.charge = target.charge;
                    copy.rush = target.rush;
                }
            }
        }
    }
}
