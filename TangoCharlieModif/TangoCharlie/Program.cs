using Robocode;
using Robocode.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class TangoCharlie : AdvancedRobot
    {
        Boolean MovingForward;
        int hitBullet = 0;
        public override void Run()
        {
            BodyColor = (Color.Pink);
            GunColor = (Color.Pink);
            RadarColor = (Color.Pink);
            ScanColor = (Color.Pink);
            BulletColor = (Color.Pink);

            while (true)
            {
                TurnGunRight(10);
                SetAhead(40000);
                MovingForward = true;
                SetTurnRight(90);
                WaitFor(new TurnCompleteCondition(this));
                SetTurnLeft(180);
                WaitFor(new TurnCompleteCondition(this));
                SetTurnRight(180);
                WaitFor(new TurnCompleteCondition(this));
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            double absoluteBearing = Heading + e.Bearing;
            double bearingFromGun = Utils.NormalRelativeAngleDegrees(absoluteBearing - GunHeading);

            if (Math.Abs(bearingFromGun) <= 3)
            {
                TurnGunRight(bearingFromGun);
                if (GunHeat == 0)
                {
                    Fire(Math.Min(3 - Math.Abs(bearingFromGun), Energy - .1));
                }
            }
            else
            {
                TurnGunRight(bearingFromGun);
            }
            if (bearingFromGun == 0)
            {
                Scan();
            }
        }

        public override void OnHitRobot(HitRobotEvent e)
        {
            if (e.Bearing > -90 && e.Bearing <= 90)
            {
                SetBack(100);
            }
            else
            {
                SetAhead(100);
            }
        }

        public override void OnHitWall(HitWallEvent evnt)
        {
            hitBullet++;
            if (hitBullet == 3)
            {
                hitBullet = 0;
                Ahead(180);
                Back(80);
            }
        }
    }


}
