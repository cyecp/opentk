#region License
//Copyright (c) 2006 Stephen Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL.Platform
{
    public partial class WindowsContext
    {
        #region OpenGL core and extension function loading

        public override void Load()
        {
            base.Load();
            GL.NewList = new GL.Delegates.NewList(GL.Imports.NewList);
            GL.EndList = new GL.Delegates.EndList(GL.Imports.EndList);
            GL.CallList = new GL.Delegates.CallList(GL.Imports.CallList);
            GL.CallLists_ = new GL.Delegates.CallLists_(GL.Imports.CallLists_);
            GL.DeleteLists = new GL.Delegates.DeleteLists(GL.Imports.DeleteLists);
            GL.GenLists = new GL.Delegates.GenLists(GL.Imports.GenLists);
            GL.ListBase = new GL.Delegates.ListBase(GL.Imports.ListBase);
            GL.Begin = new GL.Delegates.Begin(GL.Imports.Begin);
            GL.Bitmap_ = new GL.Delegates.Bitmap_(GL.Imports.Bitmap_);
            GL.Color3b = new GL.Delegates.Color3b(GL.Imports.Color3b);
            GL.Color3bv_ = new GL.Delegates.Color3bv_(GL.Imports.Color3bv_);
            GL.Color3d = new GL.Delegates.Color3d(GL.Imports.Color3d);
            GL.Color3dv_ = new GL.Delegates.Color3dv_(GL.Imports.Color3dv_);
            GL.Color3f = new GL.Delegates.Color3f(GL.Imports.Color3f);
            GL.Color3fv_ = new GL.Delegates.Color3fv_(GL.Imports.Color3fv_);
            GL.Color3i = new GL.Delegates.Color3i(GL.Imports.Color3i);
            GL.Color3iv_ = new GL.Delegates.Color3iv_(GL.Imports.Color3iv_);
            GL.Color3s = new GL.Delegates.Color3s(GL.Imports.Color3s);
            GL.Color3sv_ = new GL.Delegates.Color3sv_(GL.Imports.Color3sv_);
            GL.Color3ub = new GL.Delegates.Color3ub(GL.Imports.Color3ub);
            GL.Color3ubv_ = new GL.Delegates.Color3ubv_(GL.Imports.Color3ubv_);
            GL.Color3ui = new GL.Delegates.Color3ui(GL.Imports.Color3ui);
            GL.Color3uiv_ = new GL.Delegates.Color3uiv_(GL.Imports.Color3uiv_);
            GL.Color3us = new GL.Delegates.Color3us(GL.Imports.Color3us);
            GL.Color3usv_ = new GL.Delegates.Color3usv_(GL.Imports.Color3usv_);
            GL.Color4b = new GL.Delegates.Color4b(GL.Imports.Color4b);
            GL.Color4bv_ = new GL.Delegates.Color4bv_(GL.Imports.Color4bv_);
            GL.Color4d = new GL.Delegates.Color4d(GL.Imports.Color4d);
            GL.Color4dv_ = new GL.Delegates.Color4dv_(GL.Imports.Color4dv_);
            GL.Color4f = new GL.Delegates.Color4f(GL.Imports.Color4f);
            GL.Color4fv_ = new GL.Delegates.Color4fv_(GL.Imports.Color4fv_);
            GL.Color4i = new GL.Delegates.Color4i(GL.Imports.Color4i);
            GL.Color4iv_ = new GL.Delegates.Color4iv_(GL.Imports.Color4iv_);
            GL.Color4s = new GL.Delegates.Color4s(GL.Imports.Color4s);
            GL.Color4sv_ = new GL.Delegates.Color4sv_(GL.Imports.Color4sv_);
            GL.Color4ub = new GL.Delegates.Color4ub(GL.Imports.Color4ub);
            GL.Color4ubv_ = new GL.Delegates.Color4ubv_(GL.Imports.Color4ubv_);
            GL.Color4ui = new GL.Delegates.Color4ui(GL.Imports.Color4ui);
            GL.Color4uiv_ = new GL.Delegates.Color4uiv_(GL.Imports.Color4uiv_);
            GL.Color4us = new GL.Delegates.Color4us(GL.Imports.Color4us);
            GL.Color4usv_ = new GL.Delegates.Color4usv_(GL.Imports.Color4usv_);
            GL.EdgeFlag = new GL.Delegates.EdgeFlag(GL.Imports.EdgeFlag);
            GL.EdgeFlagv = new GL.Delegates.EdgeFlagv(GL.Imports.EdgeFlagv);
            GL.End = new GL.Delegates.End(GL.Imports.End);
            GL.Indexd = new GL.Delegates.Indexd(GL.Imports.Indexd);
            GL.Indexdv_ = new GL.Delegates.Indexdv_(GL.Imports.Indexdv_);
            GL.Indexf = new GL.Delegates.Indexf(GL.Imports.Indexf);
            GL.Indexfv_ = new GL.Delegates.Indexfv_(GL.Imports.Indexfv_);
            GL.Indexi = new GL.Delegates.Indexi(GL.Imports.Indexi);
            GL.Indexiv_ = new GL.Delegates.Indexiv_(GL.Imports.Indexiv_);
            GL.Indexs = new GL.Delegates.Indexs(GL.Imports.Indexs);
            GL.Indexsv_ = new GL.Delegates.Indexsv_(GL.Imports.Indexsv_);
            GL.Normal3b = new GL.Delegates.Normal3b(GL.Imports.Normal3b);
            GL.Normal3bv_ = new GL.Delegates.Normal3bv_(GL.Imports.Normal3bv_);
            GL.Normal3d = new GL.Delegates.Normal3d(GL.Imports.Normal3d);
            GL.Normal3dv_ = new GL.Delegates.Normal3dv_(GL.Imports.Normal3dv_);
            GL.Normal3f = new GL.Delegates.Normal3f(GL.Imports.Normal3f);
            GL.Normal3fv_ = new GL.Delegates.Normal3fv_(GL.Imports.Normal3fv_);
            GL.Normal3i = new GL.Delegates.Normal3i(GL.Imports.Normal3i);
            GL.Normal3iv_ = new GL.Delegates.Normal3iv_(GL.Imports.Normal3iv_);
            GL.Normal3s = new GL.Delegates.Normal3s(GL.Imports.Normal3s);
            GL.Normal3sv_ = new GL.Delegates.Normal3sv_(GL.Imports.Normal3sv_);
            GL.RasterPos2d = new GL.Delegates.RasterPos2d(GL.Imports.RasterPos2d);
            GL.RasterPos2dv_ = new GL.Delegates.RasterPos2dv_(GL.Imports.RasterPos2dv_);
            GL.RasterPos2f = new GL.Delegates.RasterPos2f(GL.Imports.RasterPos2f);
            GL.RasterPos2fv_ = new GL.Delegates.RasterPos2fv_(GL.Imports.RasterPos2fv_);
            GL.RasterPos2i = new GL.Delegates.RasterPos2i(GL.Imports.RasterPos2i);
            GL.RasterPos2iv_ = new GL.Delegates.RasterPos2iv_(GL.Imports.RasterPos2iv_);
            GL.RasterPos2s = new GL.Delegates.RasterPos2s(GL.Imports.RasterPos2s);
            GL.RasterPos2sv_ = new GL.Delegates.RasterPos2sv_(GL.Imports.RasterPos2sv_);
            GL.RasterPos3d = new GL.Delegates.RasterPos3d(GL.Imports.RasterPos3d);
            GL.RasterPos3dv_ = new GL.Delegates.RasterPos3dv_(GL.Imports.RasterPos3dv_);
            GL.RasterPos3f = new GL.Delegates.RasterPos3f(GL.Imports.RasterPos3f);
            GL.RasterPos3fv_ = new GL.Delegates.RasterPos3fv_(GL.Imports.RasterPos3fv_);
            GL.RasterPos3i = new GL.Delegates.RasterPos3i(GL.Imports.RasterPos3i);
            GL.RasterPos3iv_ = new GL.Delegates.RasterPos3iv_(GL.Imports.RasterPos3iv_);
            GL.RasterPos3s = new GL.Delegates.RasterPos3s(GL.Imports.RasterPos3s);
            GL.RasterPos3sv_ = new GL.Delegates.RasterPos3sv_(GL.Imports.RasterPos3sv_);
            GL.RasterPos4d = new GL.Delegates.RasterPos4d(GL.Imports.RasterPos4d);
            GL.RasterPos4dv_ = new GL.Delegates.RasterPos4dv_(GL.Imports.RasterPos4dv_);
            GL.RasterPos4f = new GL.Delegates.RasterPos4f(GL.Imports.RasterPos4f);
            GL.RasterPos4fv_ = new GL.Delegates.RasterPos4fv_(GL.Imports.RasterPos4fv_);
            GL.RasterPos4i = new GL.Delegates.RasterPos4i(GL.Imports.RasterPos4i);
            GL.RasterPos4iv_ = new GL.Delegates.RasterPos4iv_(GL.Imports.RasterPos4iv_);
            GL.RasterPos4s = new GL.Delegates.RasterPos4s(GL.Imports.RasterPos4s);
            GL.RasterPos4sv_ = new GL.Delegates.RasterPos4sv_(GL.Imports.RasterPos4sv_);
            GL.Rectd = new GL.Delegates.Rectd(GL.Imports.Rectd);
            GL.Rectdv_ = new GL.Delegates.Rectdv_(GL.Imports.Rectdv_);
            GL.Rectf = new GL.Delegates.Rectf(GL.Imports.Rectf);
            GL.Rectfv_ = new GL.Delegates.Rectfv_(GL.Imports.Rectfv_);
            GL.Recti = new GL.Delegates.Recti(GL.Imports.Recti);
            GL.Rectiv_ = new GL.Delegates.Rectiv_(GL.Imports.Rectiv_);
            GL.Rects = new GL.Delegates.Rects(GL.Imports.Rects);
            GL.Rectsv_ = new GL.Delegates.Rectsv_(GL.Imports.Rectsv_);
            GL.TexCoord1d = new GL.Delegates.TexCoord1d(GL.Imports.TexCoord1d);
            GL.TexCoord1dv_ = new GL.Delegates.TexCoord1dv_(GL.Imports.TexCoord1dv_);
            GL.TexCoord1f = new GL.Delegates.TexCoord1f(GL.Imports.TexCoord1f);
            GL.TexCoord1fv_ = new GL.Delegates.TexCoord1fv_(GL.Imports.TexCoord1fv_);
            GL.TexCoord1i = new GL.Delegates.TexCoord1i(GL.Imports.TexCoord1i);
            GL.TexCoord1iv_ = new GL.Delegates.TexCoord1iv_(GL.Imports.TexCoord1iv_);
            GL.TexCoord1s = new GL.Delegates.TexCoord1s(GL.Imports.TexCoord1s);
            GL.TexCoord1sv_ = new GL.Delegates.TexCoord1sv_(GL.Imports.TexCoord1sv_);
            GL.TexCoord2d = new GL.Delegates.TexCoord2d(GL.Imports.TexCoord2d);
            GL.TexCoord2dv_ = new GL.Delegates.TexCoord2dv_(GL.Imports.TexCoord2dv_);
            GL.TexCoord2f = new GL.Delegates.TexCoord2f(GL.Imports.TexCoord2f);
            GL.TexCoord2fv_ = new GL.Delegates.TexCoord2fv_(GL.Imports.TexCoord2fv_);
            GL.TexCoord2i = new GL.Delegates.TexCoord2i(GL.Imports.TexCoord2i);
            GL.TexCoord2iv_ = new GL.Delegates.TexCoord2iv_(GL.Imports.TexCoord2iv_);
            GL.TexCoord2s = new GL.Delegates.TexCoord2s(GL.Imports.TexCoord2s);
            GL.TexCoord2sv_ = new GL.Delegates.TexCoord2sv_(GL.Imports.TexCoord2sv_);
            GL.TexCoord3d = new GL.Delegates.TexCoord3d(GL.Imports.TexCoord3d);
            GL.TexCoord3dv_ = new GL.Delegates.TexCoord3dv_(GL.Imports.TexCoord3dv_);
            GL.TexCoord3f = new GL.Delegates.TexCoord3f(GL.Imports.TexCoord3f);
            GL.TexCoord3fv_ = new GL.Delegates.TexCoord3fv_(GL.Imports.TexCoord3fv_);
            GL.TexCoord3i = new GL.Delegates.TexCoord3i(GL.Imports.TexCoord3i);
            GL.TexCoord3iv_ = new GL.Delegates.TexCoord3iv_(GL.Imports.TexCoord3iv_);
            GL.TexCoord3s = new GL.Delegates.TexCoord3s(GL.Imports.TexCoord3s);
            GL.TexCoord3sv_ = new GL.Delegates.TexCoord3sv_(GL.Imports.TexCoord3sv_);
            GL.TexCoord4d = new GL.Delegates.TexCoord4d(GL.Imports.TexCoord4d);
            GL.TexCoord4dv_ = new GL.Delegates.TexCoord4dv_(GL.Imports.TexCoord4dv_);
            GL.TexCoord4f = new GL.Delegates.TexCoord4f(GL.Imports.TexCoord4f);
            GL.TexCoord4fv_ = new GL.Delegates.TexCoord4fv_(GL.Imports.TexCoord4fv_);
            GL.TexCoord4i = new GL.Delegates.TexCoord4i(GL.Imports.TexCoord4i);
            GL.TexCoord4iv_ = new GL.Delegates.TexCoord4iv_(GL.Imports.TexCoord4iv_);
            GL.TexCoord4s = new GL.Delegates.TexCoord4s(GL.Imports.TexCoord4s);
            GL.TexCoord4sv_ = new GL.Delegates.TexCoord4sv_(GL.Imports.TexCoord4sv_);
            GL.Vertex2d = new GL.Delegates.Vertex2d(GL.Imports.Vertex2d);
            GL.Vertex2dv_ = new GL.Delegates.Vertex2dv_(GL.Imports.Vertex2dv_);
            GL.Vertex2f = new GL.Delegates.Vertex2f(GL.Imports.Vertex2f);
            GL.Vertex2fv_ = new GL.Delegates.Vertex2fv_(GL.Imports.Vertex2fv_);
            GL.Vertex2i = new GL.Delegates.Vertex2i(GL.Imports.Vertex2i);
            GL.Vertex2iv_ = new GL.Delegates.Vertex2iv_(GL.Imports.Vertex2iv_);
            GL.Vertex2s = new GL.Delegates.Vertex2s(GL.Imports.Vertex2s);
            GL.Vertex2sv_ = new GL.Delegates.Vertex2sv_(GL.Imports.Vertex2sv_);
            GL.Vertex3d = new GL.Delegates.Vertex3d(GL.Imports.Vertex3d);
            GL.Vertex3dv_ = new GL.Delegates.Vertex3dv_(GL.Imports.Vertex3dv_);
            GL.Vertex3f = new GL.Delegates.Vertex3f(GL.Imports.Vertex3f);
            GL.Vertex3fv_ = new GL.Delegates.Vertex3fv_(GL.Imports.Vertex3fv_);
            GL.Vertex3i = new GL.Delegates.Vertex3i(GL.Imports.Vertex3i);
            GL.Vertex3iv_ = new GL.Delegates.Vertex3iv_(GL.Imports.Vertex3iv_);
            GL.Vertex3s = new GL.Delegates.Vertex3s(GL.Imports.Vertex3s);
            GL.Vertex3sv_ = new GL.Delegates.Vertex3sv_(GL.Imports.Vertex3sv_);
            GL.Vertex4d = new GL.Delegates.Vertex4d(GL.Imports.Vertex4d);
            GL.Vertex4dv_ = new GL.Delegates.Vertex4dv_(GL.Imports.Vertex4dv_);
            GL.Vertex4f = new GL.Delegates.Vertex4f(GL.Imports.Vertex4f);
            GL.Vertex4fv_ = new GL.Delegates.Vertex4fv_(GL.Imports.Vertex4fv_);
            GL.Vertex4i = new GL.Delegates.Vertex4i(GL.Imports.Vertex4i);
            GL.Vertex4iv_ = new GL.Delegates.Vertex4iv_(GL.Imports.Vertex4iv_);
            GL.Vertex4s = new GL.Delegates.Vertex4s(GL.Imports.Vertex4s);
            GL.Vertex4sv_ = new GL.Delegates.Vertex4sv_(GL.Imports.Vertex4sv_);
            GL.ClipPlane_ = new GL.Delegates.ClipPlane_(GL.Imports.ClipPlane_);
            GL.ColorMaterial = new GL.Delegates.ColorMaterial(GL.Imports.ColorMaterial);
            GL.CullFace = new GL.Delegates.CullFace(GL.Imports.CullFace);
            GL.Fogf = new GL.Delegates.Fogf(GL.Imports.Fogf);
            GL.Fogfv_ = new GL.Delegates.Fogfv_(GL.Imports.Fogfv_);
            GL.Fogi = new GL.Delegates.Fogi(GL.Imports.Fogi);
            GL.Fogiv_ = new GL.Delegates.Fogiv_(GL.Imports.Fogiv_);
            GL.FrontFace = new GL.Delegates.FrontFace(GL.Imports.FrontFace);
            GL.Hint = new GL.Delegates.Hint(GL.Imports.Hint);
            GL.Lightf = new GL.Delegates.Lightf(GL.Imports.Lightf);
            GL.Lightfv_ = new GL.Delegates.Lightfv_(GL.Imports.Lightfv_);
            GL.Lighti = new GL.Delegates.Lighti(GL.Imports.Lighti);
            GL.Lightiv_ = new GL.Delegates.Lightiv_(GL.Imports.Lightiv_);
            GL.LightModelf = new GL.Delegates.LightModelf(GL.Imports.LightModelf);
            GL.LightModelfv_ = new GL.Delegates.LightModelfv_(GL.Imports.LightModelfv_);
            GL.LightModeli = new GL.Delegates.LightModeli(GL.Imports.LightModeli);
            GL.LightModeliv_ = new GL.Delegates.LightModeliv_(GL.Imports.LightModeliv_);
            GL.LineStipple = new GL.Delegates.LineStipple(GL.Imports.LineStipple);
            GL.LineWidth = new GL.Delegates.LineWidth(GL.Imports.LineWidth);
            GL.Materialf = new GL.Delegates.Materialf(GL.Imports.Materialf);
            GL.Materialfv_ = new GL.Delegates.Materialfv_(GL.Imports.Materialfv_);
            GL.Materiali = new GL.Delegates.Materiali(GL.Imports.Materiali);
            GL.Materialiv_ = new GL.Delegates.Materialiv_(GL.Imports.Materialiv_);
            GL.PointSize = new GL.Delegates.PointSize(GL.Imports.PointSize);
            GL.PolygonMode = new GL.Delegates.PolygonMode(GL.Imports.PolygonMode);
            GL.PolygonStipple_ = new GL.Delegates.PolygonStipple_(GL.Imports.PolygonStipple_);
            GL.Scissor = new GL.Delegates.Scissor(GL.Imports.Scissor);
            GL.ShadeModel = new GL.Delegates.ShadeModel(GL.Imports.ShadeModel);
            GL.TexParameterf = new GL.Delegates.TexParameterf(GL.Imports.TexParameterf);
            GL.TexParameterfv_ = new GL.Delegates.TexParameterfv_(GL.Imports.TexParameterfv_);
            GL.TexParameteri = new GL.Delegates.TexParameteri(GL.Imports.TexParameteri);
            GL.TexParameteriv_ = new GL.Delegates.TexParameteriv_(GL.Imports.TexParameteriv_);
            GL.TexImage1D = new GL.Delegates.TexImage1D(GL.Imports.TexImage1D);
            GL.TexImage2D = new GL.Delegates.TexImage2D(GL.Imports.TexImage2D);
            GL.TexEnvf = new GL.Delegates.TexEnvf(GL.Imports.TexEnvf);
            GL.TexEnvfv_ = new GL.Delegates.TexEnvfv_(GL.Imports.TexEnvfv_);
            GL.TexEnvi = new GL.Delegates.TexEnvi(GL.Imports.TexEnvi);
            GL.TexEnviv_ = new GL.Delegates.TexEnviv_(GL.Imports.TexEnviv_);
            GL.TexGend = new GL.Delegates.TexGend(GL.Imports.TexGend);
            GL.TexGendv_ = new GL.Delegates.TexGendv_(GL.Imports.TexGendv_);
            GL.TexGenf = new GL.Delegates.TexGenf(GL.Imports.TexGenf);
            GL.TexGenfv_ = new GL.Delegates.TexGenfv_(GL.Imports.TexGenfv_);
            GL.TexGeni = new GL.Delegates.TexGeni(GL.Imports.TexGeni);
            GL.TexGeniv_ = new GL.Delegates.TexGeniv_(GL.Imports.TexGeniv_);
            GL.FeedbackBuffer = new GL.Delegates.FeedbackBuffer(GL.Imports.FeedbackBuffer);
            GL.SelectBuffer = new GL.Delegates.SelectBuffer(GL.Imports.SelectBuffer);
            GL.RenderMode = new GL.Delegates.RenderMode(GL.Imports.RenderMode);
            GL.InitNames = new GL.Delegates.InitNames(GL.Imports.InitNames);
            GL.LoadName = new GL.Delegates.LoadName(GL.Imports.LoadName);
            GL.PassThrough = new GL.Delegates.PassThrough(GL.Imports.PassThrough);
            GL.PopName = new GL.Delegates.PopName(GL.Imports.PopName);
            GL.PushName = new GL.Delegates.PushName(GL.Imports.PushName);
            GL.DrawBuffer = new GL.Delegates.DrawBuffer(GL.Imports.DrawBuffer);
            GL.Clear = new GL.Delegates.Clear(GL.Imports.Clear);
            GL.ClearAccum = new GL.Delegates.ClearAccum(GL.Imports.ClearAccum);
            GL.ClearIndex = new GL.Delegates.ClearIndex(GL.Imports.ClearIndex);
            GL.ClearColor = new GL.Delegates.ClearColor(GL.Imports.ClearColor);
            GL.ClearStencil = new GL.Delegates.ClearStencil(GL.Imports.ClearStencil);
            GL.ClearDepth = new GL.Delegates.ClearDepth(GL.Imports.ClearDepth);
            GL.StencilMask = new GL.Delegates.StencilMask(GL.Imports.StencilMask);
            GL.ColorMask = new GL.Delegates.ColorMask(GL.Imports.ColorMask);
            GL.DepthMask = new GL.Delegates.DepthMask(GL.Imports.DepthMask);
            GL.IndexMask = new GL.Delegates.IndexMask(GL.Imports.IndexMask);
            GL.Accum = new GL.Delegates.Accum(GL.Imports.Accum);
            GL.Disable = new GL.Delegates.Disable(GL.Imports.Disable);
            GL.Enable = new GL.Delegates.Enable(GL.Imports.Enable);
            GL.Finish = new GL.Delegates.Finish(GL.Imports.Finish);
            GL.Flush = new GL.Delegates.Flush(GL.Imports.Flush);
            GL.PopAttrib = new GL.Delegates.PopAttrib(GL.Imports.PopAttrib);
            GL.PushAttrib = new GL.Delegates.PushAttrib(GL.Imports.PushAttrib);
            GL.Map1d_ = new GL.Delegates.Map1d_(GL.Imports.Map1d_);
            GL.Map1f_ = new GL.Delegates.Map1f_(GL.Imports.Map1f_);
            GL.Map2d_ = new GL.Delegates.Map2d_(GL.Imports.Map2d_);
            GL.Map2f_ = new GL.Delegates.Map2f_(GL.Imports.Map2f_);
            GL.MapGrid1d = new GL.Delegates.MapGrid1d(GL.Imports.MapGrid1d);
            GL.MapGrid1f = new GL.Delegates.MapGrid1f(GL.Imports.MapGrid1f);
            GL.MapGrid2d = new GL.Delegates.MapGrid2d(GL.Imports.MapGrid2d);
            GL.MapGrid2f = new GL.Delegates.MapGrid2f(GL.Imports.MapGrid2f);
            GL.EvalCoord1d = new GL.Delegates.EvalCoord1d(GL.Imports.EvalCoord1d);
            GL.EvalCoord1dv_ = new GL.Delegates.EvalCoord1dv_(GL.Imports.EvalCoord1dv_);
            GL.EvalCoord1f = new GL.Delegates.EvalCoord1f(GL.Imports.EvalCoord1f);
            GL.EvalCoord1fv_ = new GL.Delegates.EvalCoord1fv_(GL.Imports.EvalCoord1fv_);
            GL.EvalCoord2d = new GL.Delegates.EvalCoord2d(GL.Imports.EvalCoord2d);
            GL.EvalCoord2dv_ = new GL.Delegates.EvalCoord2dv_(GL.Imports.EvalCoord2dv_);
            GL.EvalCoord2f = new GL.Delegates.EvalCoord2f(GL.Imports.EvalCoord2f);
            GL.EvalCoord2fv_ = new GL.Delegates.EvalCoord2fv_(GL.Imports.EvalCoord2fv_);
            GL.EvalMesh1 = new GL.Delegates.EvalMesh1(GL.Imports.EvalMesh1);
            GL.EvalPoint1 = new GL.Delegates.EvalPoint1(GL.Imports.EvalPoint1);
            GL.EvalMesh2 = new GL.Delegates.EvalMesh2(GL.Imports.EvalMesh2);
            GL.EvalPoint2 = new GL.Delegates.EvalPoint2(GL.Imports.EvalPoint2);
            GL.AlphaFunc = new GL.Delegates.AlphaFunc(GL.Imports.AlphaFunc);
            GL.BlendFunc = new GL.Delegates.BlendFunc(GL.Imports.BlendFunc);
            GL.LogicOp = new GL.Delegates.LogicOp(GL.Imports.LogicOp);
            GL.StencilFunc = new GL.Delegates.StencilFunc(GL.Imports.StencilFunc);
            GL.StencilOp = new GL.Delegates.StencilOp(GL.Imports.StencilOp);
            GL.DepthFunc = new GL.Delegates.DepthFunc(GL.Imports.DepthFunc);
            GL.PixelZoom = new GL.Delegates.PixelZoom(GL.Imports.PixelZoom);
            GL.PixelTransferf = new GL.Delegates.PixelTransferf(GL.Imports.PixelTransferf);
            GL.PixelTransferi = new GL.Delegates.PixelTransferi(GL.Imports.PixelTransferi);
            GL.PixelStoref = new GL.Delegates.PixelStoref(GL.Imports.PixelStoref);
            GL.PixelStorei = new GL.Delegates.PixelStorei(GL.Imports.PixelStorei);
            GL.PixelMapfv_ = new GL.Delegates.PixelMapfv_(GL.Imports.PixelMapfv_);
            GL.PixelMapuiv_ = new GL.Delegates.PixelMapuiv_(GL.Imports.PixelMapuiv_);
            GL.PixelMapusv_ = new GL.Delegates.PixelMapusv_(GL.Imports.PixelMapusv_);
            GL.ReadBuffer = new GL.Delegates.ReadBuffer(GL.Imports.ReadBuffer);
            GL.CopyPixels = new GL.Delegates.CopyPixels(GL.Imports.CopyPixels);
            GL.ReadPixels_ = new GL.Delegates.ReadPixels_(GL.Imports.ReadPixels_);
            GL.DrawPixels_ = new GL.Delegates.DrawPixels_(GL.Imports.DrawPixels_);
            GL.GetBooleanv = new GL.Delegates.GetBooleanv(GL.Imports.GetBooleanv);
            GL.GetClipPlane = new GL.Delegates.GetClipPlane(GL.Imports.GetClipPlane);
            GL.GetDoublev = new GL.Delegates.GetDoublev(GL.Imports.GetDoublev);
            GL.GetError = new GL.Delegates.GetError(GL.Imports.GetError);
            GL.GetFloatv = new GL.Delegates.GetFloatv(GL.Imports.GetFloatv);
            GL.GetIntegerv = new GL.Delegates.GetIntegerv(GL.Imports.GetIntegerv);
            GL.GetLightfv = new GL.Delegates.GetLightfv(GL.Imports.GetLightfv);
            GL.GetLightiv = new GL.Delegates.GetLightiv(GL.Imports.GetLightiv);
            GL.GetMapdv = new GL.Delegates.GetMapdv(GL.Imports.GetMapdv);
            GL.GetMapfv = new GL.Delegates.GetMapfv(GL.Imports.GetMapfv);
            GL.GetMapiv = new GL.Delegates.GetMapiv(GL.Imports.GetMapiv);
            GL.GetMaterialfv = new GL.Delegates.GetMaterialfv(GL.Imports.GetMaterialfv);
            GL.GetMaterialiv = new GL.Delegates.GetMaterialiv(GL.Imports.GetMaterialiv);
            GL.GetPixelMapfv = new GL.Delegates.GetPixelMapfv(GL.Imports.GetPixelMapfv);
            GL.GetPixelMapuiv = new GL.Delegates.GetPixelMapuiv(GL.Imports.GetPixelMapuiv);
            GL.GetPixelMapusv = new GL.Delegates.GetPixelMapusv(GL.Imports.GetPixelMapusv);
            GL.GetPolygonStipple = new GL.Delegates.GetPolygonStipple(GL.Imports.GetPolygonStipple);
            GL.GetString_ = new GL.Delegates.GetString_(GL.Imports.GetString_);
            GL.GetTexEnvfv = new GL.Delegates.GetTexEnvfv(GL.Imports.GetTexEnvfv);
            GL.GetTexEnviv = new GL.Delegates.GetTexEnviv(GL.Imports.GetTexEnviv);
            GL.GetTexGendv = new GL.Delegates.GetTexGendv(GL.Imports.GetTexGendv);
            GL.GetTexGenfv = new GL.Delegates.GetTexGenfv(GL.Imports.GetTexGenfv);
            GL.GetTexGeniv = new GL.Delegates.GetTexGeniv(GL.Imports.GetTexGeniv);
            GL.GetTexImage = new GL.Delegates.GetTexImage(GL.Imports.GetTexImage);
            GL.GetTexParameterfv = new GL.Delegates.GetTexParameterfv(GL.Imports.GetTexParameterfv);
            GL.GetTexParameteriv = new GL.Delegates.GetTexParameteriv(GL.Imports.GetTexParameteriv);
            GL.GetTexLevelParameterfv = new GL.Delegates.GetTexLevelParameterfv(GL.Imports.GetTexLevelParameterfv);
            GL.GetTexLevelParameteriv = new GL.Delegates.GetTexLevelParameteriv(GL.Imports.GetTexLevelParameteriv);
            GL.IsEnabled = new GL.Delegates.IsEnabled(GL.Imports.IsEnabled);
            GL.IsList = new GL.Delegates.IsList(GL.Imports.IsList);
            GL.DepthRange = new GL.Delegates.DepthRange(GL.Imports.DepthRange);
            GL.Frustum = new GL.Delegates.Frustum(GL.Imports.Frustum);
            GL.LoadIdentity = new GL.Delegates.LoadIdentity(GL.Imports.LoadIdentity);
            GL.LoadMatrixf_ = new GL.Delegates.LoadMatrixf_(GL.Imports.LoadMatrixf_);
            GL.LoadMatrixd_ = new GL.Delegates.LoadMatrixd_(GL.Imports.LoadMatrixd_);
            GL.MatrixMode = new GL.Delegates.MatrixMode(GL.Imports.MatrixMode);
            GL.MultMatrixf_ = new GL.Delegates.MultMatrixf_(GL.Imports.MultMatrixf_);
            GL.MultMatrixd_ = new GL.Delegates.MultMatrixd_(GL.Imports.MultMatrixd_);
            GL.Ortho = new GL.Delegates.Ortho(GL.Imports.Ortho);
            GL.PopMatrix = new GL.Delegates.PopMatrix(GL.Imports.PopMatrix);
            GL.PushMatrix = new GL.Delegates.PushMatrix(GL.Imports.PushMatrix);
            GL.Rotated = new GL.Delegates.Rotated(GL.Imports.Rotated);
            GL.Rotatef = new GL.Delegates.Rotatef(GL.Imports.Rotatef);
            GL.Scaled = new GL.Delegates.Scaled(GL.Imports.Scaled);
            GL.Scalef = new GL.Delegates.Scalef(GL.Imports.Scalef);
            GL.Translated = new GL.Delegates.Translated(GL.Imports.Translated);
            GL.Translatef = new GL.Delegates.Translatef(GL.Imports.Translatef);
            GL.Viewport = new GL.Delegates.Viewport(GL.Imports.Viewport);
            GL.ArrayElement = new GL.Delegates.ArrayElement(GL.Imports.ArrayElement);
            GL.ColorPointer_ = new GL.Delegates.ColorPointer_(GL.Imports.ColorPointer_);
            GL.DisableClientState = new GL.Delegates.DisableClientState(GL.Imports.DisableClientState);
            GL.DrawArrays = new GL.Delegates.DrawArrays(GL.Imports.DrawArrays);
            GL.DrawElements_ = new GL.Delegates.DrawElements_(GL.Imports.DrawElements_);
            GL.EdgeFlagPointer_ = new GL.Delegates.EdgeFlagPointer_(GL.Imports.EdgeFlagPointer_);
            GL.EnableClientState = new GL.Delegates.EnableClientState(GL.Imports.EnableClientState);
            GL.GetPointerv = new GL.Delegates.GetPointerv(GL.Imports.GetPointerv);
            GL.IndexPointer_ = new GL.Delegates.IndexPointer_(GL.Imports.IndexPointer_);
            GL.InterleavedArrays_ = new GL.Delegates.InterleavedArrays_(GL.Imports.InterleavedArrays_);
            GL.NormalPointer_ = new GL.Delegates.NormalPointer_(GL.Imports.NormalPointer_);
            GL.TexCoordPointer_ = new GL.Delegates.TexCoordPointer_(GL.Imports.TexCoordPointer_);
            GL.VertexPointer_ = new GL.Delegates.VertexPointer_(GL.Imports.VertexPointer_);
            GL.PolygonOffset = new GL.Delegates.PolygonOffset(GL.Imports.PolygonOffset);
            GL.CopyTexImage1D = new GL.Delegates.CopyTexImage1D(GL.Imports.CopyTexImage1D);
            GL.CopyTexImage2D = new GL.Delegates.CopyTexImage2D(GL.Imports.CopyTexImage2D);
            GL.CopyTexSubImage1D = new GL.Delegates.CopyTexSubImage1D(GL.Imports.CopyTexSubImage1D);
            GL.CopyTexSubImage2D = new GL.Delegates.CopyTexSubImage2D(GL.Imports.CopyTexSubImage2D);
            GL.TexSubImage1D = new GL.Delegates.TexSubImage1D(GL.Imports.TexSubImage1D);
            GL.TexSubImage2D = new GL.Delegates.TexSubImage2D(GL.Imports.TexSubImage2D);
            GL.AreTexturesResident_ = new GL.Delegates.AreTexturesResident_(GL.Imports.AreTexturesResident_);
            GL.BindTexture = new GL.Delegates.BindTexture(GL.Imports.BindTexture);
            GL.DeleteTextures_ = new GL.Delegates.DeleteTextures_(GL.Imports.DeleteTextures_);
            GL.GenTextures = new GL.Delegates.GenTextures(GL.Imports.GenTextures);
            GL.IsTexture = new GL.Delegates.IsTexture(GL.Imports.IsTexture);
            GL.PrioritizeTextures_ = new GL.Delegates.PrioritizeTextures_(GL.Imports.PrioritizeTextures_);
            GL.Indexub = new GL.Delegates.Indexub(GL.Imports.Indexub);
            GL.Indexubv_ = new GL.Delegates.Indexubv_(GL.Imports.Indexubv_);
            GL.PopClientAttrib = new GL.Delegates.PopClientAttrib(GL.Imports.PopClientAttrib);
            GL.PushClientAttrib = new GL.Delegates.PushClientAttrib(GL.Imports.PushClientAttrib);
        }
        #endregion
    }
}

