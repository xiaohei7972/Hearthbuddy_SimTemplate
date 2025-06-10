using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：7 攻击力：7 生命值：7
	//Kalimos, Primal Lord
	//荒蛮之主卡利莫斯
	//[x]<b>Battlecry:</b> If you played anElemental last turn, cast anElemental Invocation.
	//<b>战吼：</b>如果你在上个回合使用过元素牌，则施放一个元素祈咒。
	class Sim_Core_UNG_211 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            // 根据玩家选择的选项（choice）来决定添加哪张卡牌

            if (choice == 1)
            {
                selectedCardID = CardDB.cardIDEnum.UNG_211a; // 土之祈咒
            }
            else if (choice == 2)
            {
                selectedCardID = CardDB.cardIDEnum.UNG_211b; // 水之祈咒
            }
            else if (choice == 3)
            {
                selectedCardID = CardDB.cardIDEnum.UNG_211c; // 火之祈咒
            }
            else if (choice == 4)
            {
                selectedCardID = CardDB.cardIDEnum.UNG_211d; // 气之祈咒
            }

        }
    }
}

		
	

