using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：1
	//Pop-Up Book
	//立体书
	//Deal $2 damage. Summon two 0/1 Frogs with <b>Taunt</b>.
	//造成$2点伤害。召唤两只0/1并具有<b>嘲讽</b>的青蛙。
	class Sim_TOY_508 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 对目标造成2点伤害
            p.minionGetDamageOrHeal(target, 2);

            // 召唤两只0/1并具有嘲讽的青蛙
            for (int i = 0; i < 2; i++)
            {
                if (p.ownMinions.Count < 7) // 确保场上有空位
                {
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.hexfrog), p.ownMinions.Count, ownplay); // 假设青蛙的ID为hexfrog
                    Minion frog = p.ownMinions[p.ownMinions.Count - 1];
                    frog.taunt = true; // 设置青蛙具有嘲讽属性
                }
            }
        }
    }
}
