﻿using System.Windows;
using ChatEmotions.Domain;
using ChatEmotions.InterfaceAdapter;
using ChatEmotions.Presentation.ViewModels;

namespace ChatEmotions.Presentation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        DataContext = new MsgViewModel(new XMLAdapter());
    }
}