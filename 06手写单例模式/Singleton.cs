using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06手写单例模式
{
    public class Singleton
    {
        //目前的单例模式有懒汉模式   以及饿汉模式    以及涉及到线程安全  
        //几个关键点
        //1、首先默认的无参构造函数必须是私有的，保证不会通过new()操作来创建一个实例，达到实现单例的目的、
        //2、因为静态变量的生命周期跟整个应用程序的生命周期是一样的，所有可以定义一个私有的静态全局变量instance来保存该类的唯一实例
        //3、必须提供一个全局函数访问获得该实例，并且在该函数中控制实例数量的功能，即通过if语句判断instance是否已被实例化，
        //如果没有，则可以通过new()来创建一个实例；否则，直接向客户返回一个实例。
        //4、这种经典模式  并没有考虑线程并发的问题，当两个线程同时获取instance实例时，而其为null，这样就会出现两个线程分别创建了
        //instance实例，违背了单例原则

        //懒汉式以及饿汉式的实现原理？

        private static Singleton _instance = null;
        //确保线程同步
        private static readonly  object lockObj=new object();
        
        private Singleton() { }
        public static Singleton GetSingleton()
        {
            //这里双重判断  避免不必要的加锁   Double-Check
            if (_instance==null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }


    }
}
