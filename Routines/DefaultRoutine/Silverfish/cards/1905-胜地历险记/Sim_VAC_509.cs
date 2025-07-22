using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：10
	//Tsunami
	//海啸
	//Summon four3/6 Water Elementals that <b>Freeze</b>. They attack random enemies.
	//召唤四个3/6的可以<b>冻结</b>攻击目标的水元素，并使其随机攻击敌人。
	class Sim_VAC_509 : SimTemplate
	{


        private static Random rng = new Random(); // 创建一个静态的随机数生成器

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_509t);//水元素
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
		    p.callKid(kid, pos, ownplay);

			
	    }




	}  


}
