using System;


using System.Collections.Generic;


using System.Text;





namespace HREngine.Bots


{


	class Sim_AV_205pb : SimTemplate //* 皇血草 Kingsblood


//Draw a card.


//抽一张牌。 


	{


		


		


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)


		{


            p.drawACard(CardDB.cardIDEnum.None, ownplay);


		}


	}


}